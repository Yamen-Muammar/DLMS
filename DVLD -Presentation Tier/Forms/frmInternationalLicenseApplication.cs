using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier.Services;
using DVLD__Core;
using DVLD__Core.Models;
using DVLD__Presentation_Tier.Forms.License_Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD__Presentation_Tier.Forms
{
    public partial class frmInternationalLicenseApplication : Form
    {
        public DVLD__Core.Models.License LicenseInfo { get; set; }

        private InternationalLicense _internationalLicense;
        private ApplicationType _applicationType;
        private DVLD__Core.Models.Application application;
        private ApplicationsTypeService _applicationsTypeService;
        private readonly int applicationTypeIDinDB;
        private LicenseService _licenseService;
        public frmInternationalLicenseApplication()
        {
            InitializeComponent();
            applicationTypeIDinDB = 1;
        }


        private async void frmInternationalLicenseApplication_Load(object sender, EventArgs e)
        {
            _applicationsTypeService = new ApplicationsTypeService();
            _licenseService = new LicenseService();
            try
            {
                _applicationType = await _applicationsTypeService.GetApplicationTypeByID(applicationTypeIDinDB);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // search license button
        private async void button1_Click(object sender, EventArgs e)
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
                this.LicenseInfo =  this.ctrlDriverLicenseInfo1.LicenseInfo;



                application = _prepareAppObj();
                _fillApplicationUIForm(application);
                _toggleControls(true);

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


        // show license info
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 

        }

        //show license history
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLicenseHistory frmLicenseHistory = new frmLicenseHistory(this.ctrlDriverLicenseInfo1.PersonInfo.NationalNO);
            frmLicenseHistory.ShowDialog();
        }
        // close button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //issue button
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (LicenseInfo.isActive == false && (DateTime.Compare(DateTime.Now , LicenseInfo.ExpirationDate) >= 0))
                {
                    throw new ArgumentException("Local License is not Active");
                }

                InternationalLicense internationalLicense = _prepareInternationalLicenseObj();
                application.ApplicationDate = internationalLicense.IssueDate;
                internationalLicense.InternationalLicenseID = await _licenseService.AddInternationalLicenseAsync(application, internationalLicense);
                if (internationalLicense.InternationalLicenseID <= 0)
                {
                    MessageBox.Show("License Does not Issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("License Issued Successfully", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblILAppID.Text = internationalLicense.Application_ID.ToString();
                    lblILicID.Text = internationalLicense.InternationalLicenseID.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private InternationalLicense _prepareInternationalLicenseObj()
        {
            InternationalLicense internationalLicense = new InternationalLicense();
            internationalLicense.LocalLicense_ID = LicenseInfo.LicenseID;
            internationalLicense.CreatedBy_ID = Global.User.UserID;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.IssueDate= DateTime.Now;
            internationalLicense.IsActive = true;
            return internationalLicense;
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
            llblLicenseHistory.Enabled = enabled;
            btnSave.Enabled = enabled;
        }
        private void _fillApplicationUIForm(DVLD__Core.Models.Application application)
        {
            lblAppDate.Text = application.ApplicationDate.ToString("d");
            lblIsuueDate.Text = application.ApplicationDate.ToString("d");
            lblAppFees.Text = application.PaidFees.ToString();
            lblLocalLicenseID.Text = LicenseInfo.LicenseID.ToString();
            lblILicExpiration.Text = application.ApplicationDate.AddYears(1).ToString("d"); 
            lblCreatedBy.Text = application.CreatedByUser_ID.ToString();

        }
    }
}
