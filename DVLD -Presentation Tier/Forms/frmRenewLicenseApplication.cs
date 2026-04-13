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
using DVLD__Core;
using DVLD__Core.Models;
using DVLD__Presentation_Tier.Forms.License_Forms;

namespace DVLD__Presentation_Tier.Forms
{
    public partial class frmRenewLicenseApplication : Form
    {
        public DVLD__Core.Models.License PreviousLicenseInfo { get; set; }

        private ApplicationType _applicationType;
        private DVLD__Core.Models.Application application;
        private ApplicationsTypeService _applicationsTypeService;
        private readonly int applicationTypeIDinDB;
        private LicenseService _licenseService;
        private LicenseClassService _licenseClassService;
        private LicenseClass _licenseClass;
        public frmRenewLicenseApplication()
        {
            InitializeComponent();
            applicationTypeIDinDB = 4;
        }
        private async void frmRenewLicenseApplication_Load(object sender, EventArgs e)
        { 
            _applicationsTypeService = new ApplicationsTypeService();
            _licenseService = new LicenseService();
            _licenseClassService = new LicenseClassService();
            try
            {
                _applicationType = await _applicationsTypeService.GetApplicationTypeByID(applicationTypeIDinDB);
                if(_applicationType == null)
                {
                    this.Close();
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                this.Close();
            }
        }
        private async void btnRenew_Click(object sender, EventArgs e)
        {
            if (!_isUIFormValid())
            {
                return;
            }
            if (PreviousLicenseInfo.isActive == false)
            {
                MessageBox.Show("License is not active, you cannot renew the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _toggleControls(false);
                return;
            }

            try
            {
                DVLD__Core.Models.License newLicense = _prepareNewLicenseObj();

                newLicense.LicenseID = await _licenseService.RenewLicenseAsync(application, PreviousLicenseInfo,newLicense);
                if (newLicense.LicenseID <= 0)
                {
                    MessageBox.Show("License Does not Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("License Issued Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbRenewLAppID.Text = newLicense.Application_ID.ToString();
                    lblRenewLicenseID.Text = newLicense.LicenseID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void llblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(this.ctrlDriverLicenseInfo1.PersonInfo.NationalNO);
            frmLicenseHistory.ShowDialog();
        }

        private async void btnFindLicense_Click(object sender, EventArgs e)
        {
            int enteredlicenseID = _getLicenseID();
            if (enteredlicenseID == -1)
            {
                MessageBox.Show("Enter a valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                await this.ctrlDriverLicenseInfo1.LoadDate(enteredlicenseID);
                this.PreviousLicenseInfo = this.ctrlDriverLicenseInfo1.LicenseInfo;

                _licenseClass = await _getLicenseClassByIDAsync((int)PreviousLicenseInfo.LicenseClass_ID);
                if (_licenseClass == null)
                {
                    this.Close();
                    return;
                }

                application = _prepareAppObj();
                _fillApplicationUIForm(application);

                if (DateTime.Compare(DateTime.Now, PreviousLicenseInfo.ExpirationDate) <= 0)
                {
                    MessageBox.Show("License is not expired, you can renew the license","Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    _toggleControls(false);
                }
                else
                {
                    _toggleControls(true);
                }
            }
            catch (ArgumentNullException ex)
            {
                PreviousLicenseInfo = null;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _toggleControls(false);
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _toggleControls(false);
                return;
            }
        }

        //helper functions

        private DVLD__Core.Models.License _prepareNewLicenseObj()
        {
            DVLD__Core.Models.License newLicense = new DVLD__Core.Models.License();
            DateTime date = DateTime.Now;
            newLicense.IssueDate = date;
            newLicense.ExpirationDate = date.AddYears(_licenseClass.DefaultValidityLength);
            newLicense.isActive = true;
            newLicense.CreateByUser_ID = Global.User.UserID;
            newLicense.Driver_ID = PreviousLicenseInfo.Driver_ID;
            newLicense.Note = tbNotes.Text;
            newLicense.IssueReasen = "Renew License";
            newLicense.LicenseClass_ID = _licenseClass.LicenseClassID;
            return newLicense;
        }
        private DVLD__Core.Models.Application _prepareAppObj()
        {
            DVLD__Core.Models.Application application = new DVLD__Core.Models.Application();
            application.ApplicationStatus = "Completed";
            application.PaidFees = _applicationType.ApplicationTypeFees;
            DateTime date = DateTime.Now;
            application.ApplicationDate = date;
            application.LastStatusDate = date;
            application.ApplicationType_ID = applicationTypeIDinDB;
            application.CreatedByUser_ID = Global.User.UserID;
            application.Person_ID = this.ctrlDriverLicenseInfo1.PersonInfo.PersonID;

            return application;
        }
        private int _getLicenseID()
        {
            if (!int.TryParse(tbLicenseID.Text, out int id) || id <= 0)
            {
                return -1;
            }
            return id;
        }
        private void _toggleControls(bool enabled)
        {
            btnRenew.Enabled = enabled;
        }
        private void _fillApplicationUIForm(DVLD__Core.Models.Application application)
        {
            lblAppDate.Text = application.ApplicationDate.ToString("d");
            lblIsuueDate.Text = application.ApplicationDate.ToString("d");
            lblAppFees.Text = application.PaidFees.ToString();
            lblLocalLicenseID.Text = PreviousLicenseInfo.LicenseID.ToString();
            lblRenewExpirationDate.Text = application.ApplicationDate.AddYears(_licenseClass.DefaultValidityLength).ToString("d");
            lblCreatedBy.Text = application.CreatedByUser_ID.ToString();
            lblLicenseFees.Text = _licenseClass.ClassFees.ToString();
            lblTotalFees.Text = _calculateTotalFees().ToString();
        }

        private bool _isUIFormValid()
        {
            if (string.IsNullOrEmpty(tbNotes.Text))
            {
                MessageBox.Show("Please enter notes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private decimal _calculateTotalFees()
        {
            return _applicationType.ApplicationTypeFees + _licenseClass.ClassFees;
        }
        private async Task<LicenseClass> _getLicenseClassByIDAsync(int id)
        {
            
            return await _licenseClassService.GetLicenseClassByIDAsync(id);
        }
    }
}
