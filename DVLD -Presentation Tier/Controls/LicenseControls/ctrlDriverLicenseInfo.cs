using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier.Services;
using DVLD__Core.Models;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD__Presentation_Tier.Controls.LicenseControls
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LDLApplicationID;
        public Person PersonInfo;
        private string _licenseClassName;
        public DVLD__Core.Models.License LicenseInfo;
        private DetainedLicenseService _detainedLicenseService;
        public bool IsLicenseDetained;

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
            PersonInfo = new Person();
            LicenseInfo = new DVLD__Core.Models.License();

        }

        public async Task LoadDate(int LDLApplicationID, string nationalNo, string LicenseClassName)
        {
            _LDLApplicationID = LDLApplicationID;
            _licenseClassName = LicenseClassName;

            PersonInfo = await _getPersonDataAsync(nationalNo);
            if (PersonInfo == null)
            {
                return;
            }

            LicenseInfo = await _getLicenseDataAsync(LDLApplicationID);
            if (LicenseInfo == null)
            { 
                return;
            }
            _fillDataINCtrl();
        }

        public async Task LoadDate(int licenseID)
        {
            try
            {
                LicenseService licenseService = new LicenseService();
                DVLD__Core.Models.License licenseData = await licenseService.GetLicenseByID(licenseID);
                if (licenseData == null)
                {
                    throw new ArgumentNullException("License data Not Found");
                }
                LicenseInfo = licenseData;
               

                ApplicationService applicationService = new ApplicationService();
                DVLD__Core.Models.Application application = await applicationService.GetApplicationByID((int)licenseData.Application_ID);
                if (application == null)
                {
                    return;
                }

                LicenseClassService licenseClassService = new LicenseClassService();
                LicenseClass licenseClass = await licenseClassService.GetLicenseClassByIDAsync((int)licenseData.LicenseClass_ID);
                if (licenseClass == null)
                {
                    return;
                }
                _licenseClassName = licenseClass.ClassName;

                PersonInfo = await _getPersonDataAsync(application.Person_ID);
                if (PersonInfo == null)
                {
                    return;
                }

                _detainedLicenseService = new DetainedLicenseService();
                IsLicenseDetained = await _detainedLicenseService.IsLicenseDetained(licenseID);

                _fillDataINCtrl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                                       
            
        }


        private async Task<Person> _getPersonDataAsync(string nationalNo)
        {
            PersonService personService = new PersonService();
            try
            {
                return await personService.Find(nationalNo);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        private async Task<Person> _getPersonDataAsync(int personID)
        {
            PersonService personService = new PersonService();
            try
            {
                return await personService.Find(personID);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        private async Task<DVLD__Core.Models.License> _getLicenseDataAsync(int ldlAppID)
        {
            LicenseService licenseService = new LicenseService();
            try
            {
                return await licenseService.GetLicenseByLDLAppID(ldlAppID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void _fillDataINCtrl()
        {
            _fillPersonData();
            _fillLicenseData();
        }

        private void _fillPersonData()
        {
            lblFullName.Text = PersonInfo.FullName();
            lblNationalNoID.Text = PersonInfo.NationalNO;
            lblDateOfBirth.Text = PersonInfo.DateOfBirth.ToShortDateString();
            lblGender.Text = PersonInfo.Gender.ToString();
            pbPersonalImage.Image = _loadImageWithoutLock(PersonInfo.ImageName);
        }       
        private void _fillLicenseData()
        {
            lblLicenseID.Text = LicenseInfo.LicenseID.ToString();
            lblClassName.Text = _licenseClassName;
            lblDriverID.Text = LicenseInfo.Driver_ID.ToString();
            lblIsActive.Text = LicenseInfo.isActive ? "Yes" : "No";
            lblIssueDate.Text = LicenseInfo.IssueDate.ToShortDateString();
            lblExperationDate.Text = LicenseInfo.ExpirationDate.ToShortDateString();
            lblNotes.Text = LicenseInfo.Note.ToString();
            lblIssueReason.Text = LicenseInfo.IssueReasen.ToString();
            lblIsDetained.Text = (IsLicenseDetained) ? "Yes" : "No"; 
        }

        private System.Drawing.Image _loadImageWithoutLock(string imageName)
        {
            string imagePath = Path.Combine(@"F:\yamen - 2024\C#\Course\projects\PersonPic", imageName);

            if (!File.Exists(imagePath))
            {
                return null;
            }

            using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                return System.Drawing.Image.FromStream(fs);
            }
        }
    }
}
