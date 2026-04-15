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

namespace DVLD__Presentation_Tier.Forms.DetainedLicenseForms
{
    public partial class frmReleaseDetainedLicense : Form
    {
        public DVLD__Core.Models.License LicenseInfo { get; set; }
        private DetainedLicense DetainedLicenseInfo;

        private int _detainedLicenseId; 
        private int _licenseId;
        private ApplicationType _applicationType;
        private DVLD__Core.Models.Application application;
        private ApplicationsTypeService _applicationsTypeService;
        private readonly int applicationTypeIDinDB;
        private LicenseService _licenseService;
        private DetainedLicenseService _detainedLicenseService;
        
        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
            applicationTypeIDinDB = 3;
        }
        public frmReleaseDetainedLicense(int detaineID,int licenseID)
        {
            InitializeComponent();
            applicationTypeIDinDB = 3;
            _licenseId = licenseID;
            _detainedLicenseId = detaineID;
        }
        private async void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            _detainedLicenseService = new DetainedLicenseService();
            _applicationsTypeService = new ApplicationsTypeService();
            try
            {
                _applicationType = await _applicationsTypeService.GetApplicationTypeByID(applicationTypeIDinDB);
                if (_applicationType == null)
                {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
            if (_licenseId > 0 && _detainedLicenseId > 0)
            {
                btnFindLicense.PerformClick();
                gbFinder.Enabled = false;
            }
        }
        private async void btnRelease_Click(object sender, EventArgs e)
        {
            try
            {
                DetainedLicenseInfo.ReleaseByUser_ID = Global.User.UserID;

                await _detainedLicenseService.ReleaseDetainedLicenseAsync(application,DetainedLicenseInfo);
                if (DetainedLicenseInfo.ReleaseApplication_ID <= 0)
                {
                    MessageBox.Show("License Does not Released", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("License Released Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _toggleControls(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _toggleControls(false);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void llblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory frmLicense = new frmLicenseHistory(this.ctrlDriverLicenseInfo1.PersonInfo.NationalNO);
            frmLicense.ShowDialog();
        }
        private async void btnFindLicense_Click(object sender, EventArgs e)
        {
            int enteredlicenseID = -1;
            if (_licenseId == 0 || _licenseId == -1)
            {
                enteredlicenseID = _getLicenseID();
                if (enteredlicenseID == -1)
                {
                    MessageBox.Show("Enter a valid ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                enteredlicenseID = _licenseId;
            }

            

            try
            {
                await this.ctrlDriverLicenseInfo1.LoadDate(enteredlicenseID);
                this.LicenseInfo = this.ctrlDriverLicenseInfo1.LicenseInfo;

                application = _prepareAppObj();

                DetainedLicenseInfo = await _detainedLicenseService.GetDetainedLicenseByLicenseIDAsync(enteredlicenseID);
                if (DetainedLicenseInfo == null)
                {
                    MessageBox.Show("No Detained License Found with the entered ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _toggleControls(false);
                    return;
                }
                _fillApplicationUIForm(application);

                if (!this.ctrlDriverLicenseInfo1.IsLicenseDetained)
                {
                    MessageBox.Show("License is not Detained, you can release the license", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _toggleControls(false);
                }
                else
                {
                    _toggleControls(true);
                }
            }
            catch (ArgumentNullException ex)
            {
                LicenseInfo = null;
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
            btnRelease.Enabled = enabled;
        }
        private void _fillApplicationUIForm(DVLD__Core.Models.Application application)
        {
            lblApplicationDate.Text = application.ApplicationDate.ToString("d");
            lblDetaindDate.Text = DetainedLicenseInfo.DetainDate.ToString("d");
            lblFineFees.Text = DetainedLicenseInfo.FineFees.ToString();
            lblLocalLicenseID.Text = LicenseInfo.LicenseID.ToString();
            lblCreatedBy.Text = application.CreatedByUser_ID.ToString();
            lblDetainedID.Text = DetainedLicenseInfo.DetainID.ToString();
            lblTotalFees.Text = _calculateTotalFees().ToString();
        }

        private decimal _calculateTotalFees()
        {
            return DetainedLicenseInfo.FineFees + _applicationType.ApplicationTypeFees;
        }

        
    }
}
