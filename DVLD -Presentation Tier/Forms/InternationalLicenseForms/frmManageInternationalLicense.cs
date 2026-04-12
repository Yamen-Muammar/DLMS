using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier.Services;
using DVLD__Core.View_Models;
using DVLD__Presentation_Tier.Forms.License_Forms;

namespace DVLD__Presentation_Tier.Forms.InternationalLicenseForms
{
    public partial class frmManageInternationalLicense : Form
    {
        private List<clsInternationalLicenseHistory> _internatioanlLicenseList;

        private LicenseService _licenseService;
        private ApplicationService _applicationService;
        public frmManageInternationalLicense()
        {
            InitializeComponent();
        }
        private async void frmManageInternationalLicense_Load(object sender, EventArgs e)
        {
            _licenseService = new LicenseService();
            await _refreshDataGridView();
        }
        private async void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int person_id = await _getPersonID();
            if (person_id == -1)
            {
                return;
            }
            frmPersonInformation frmPersonInformation = new frmPersonInformation(person_id);
            frmPersonInformation.ShowDialog();
        }

        private void localLiscenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int license_id = _getLicenseID();
            if (license_id == -1) { return; }
            frmLicenseInformation frmLicenseInformation = new frmLicenseInformation(license_id);
            frmLicenseInformation.ShowDialog();
        }

        private async void showPersonLicesneHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nationalNo = await _getPersonNationalNoByID();
            if (nationalNo == null) { return; }

            frmLicenseHistory frmLicense = new frmLicenseHistory(nationalNo);
            frmLicense.ShowDialog();
        }

        private async void btnAddInternationalLicense_Click(object sender, EventArgs e)
        {
            frmInternationalLicenseApplication frm = new frmInternationalLicenseApplication();
            frm.ShowDialog();
            await _refreshDataGridView();
        }

        private async Task<List<clsInternationalLicenseHistory>> _getInternatioanlLicenseList()
        {
            try
            {
                return await _licenseService.GetAllIntarnationalLicense();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<clsInternationalLicenseHistory>();
            }
        }

        private async Task<int> _getPersonID()
        {
            _applicationService = new ApplicationService();
            try
            {
                int appID =(int) dgvInternationalLicenseList.CurrentRow?.Cells["Application_ID"].Value;

                 return (int)(await _applicationService.GetApplicationByID(appID)).Person_ID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return -1;
            }
        }
        private async Task<string> _getPersonNationalNoByID()
        {
            _applicationService = new ApplicationService();
            try
            {
                int appID = (int)dgvInternationalLicenseList.CurrentRow?.Cells["Application_ID"].Value;
                int personID = (int)(await _applicationService.GetApplicationByID(appID)).Person_ID;
                PersonService personService = new PersonService();
                string nationalNo = (await personService.Find(personID)).NationalNO;

                return nationalNo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private int _getLicenseID()
        {
            try
            {
                return (int)dgvInternationalLicenseList.CurrentRow?.Cells["LocalLicense_ID"].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        private void _setDataGridView(List<clsInternationalLicenseHistory> internationalLicenseList)
        {
            dgvInternationalLicenseList.DataSource = null;
            dgvInternationalLicenseList.DataSource = internationalLicenseList;
        }

        private async Task _refreshDataGridView()
        {
            _internatioanlLicenseList = await _getInternatioanlLicenseList();
            _setDataGridView(_internatioanlLicenseList); 
        }
    }
}
