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
        private Person _person;
        private string _licenseClassName;
        private DVLD__Core.Models.License _license;
        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
            _person = new Person();
            _license = new DVLD__Core.Models.License();
        }

        public async Task LoadDate(int LDLApplicationID, string nationalNo, string LicenseClassName)
        {
            _LDLApplicationID = LDLApplicationID;
            _licenseClassName = LicenseClassName;

            _person = await _getPersonDataAsync(nationalNo);
            if (_person == null)
            {
                return;
            }

            _license = await _getLicenseDataAsync(LDLApplicationID);
            if (_license == null)
            { 
                return;
            }
            _fillDataINCtrl();
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
            lblFullName.Text = _person.FullName();
            lblNationalNoID.Text = _person.NationalNO;
            lblDateOfBirth.Text = _person.DateOfBirth.ToShortDateString();
            lblGender.Text = _person.Gender.ToString();
            pbPersonalImage.Image = _loadImageWithoutLock(_person.ImageName);
        }       
        private void _fillLicenseData()
        {
            lblLicenseID.Text = _license.LicenseID.ToString();
            lblClassName.Text = _licenseClassName;
            lblDriverID.Text = _license.Driver_ID.ToString();
            lblIsActive.Text = _license.isActive ? "Yes" : "No";
            lblIssueDate.Text = _license.IssueDate.ToShortDateString();
            lblExperationDate.Text = _license.ExpirationDate.ToShortDateString();
            lblNotes.Text = _license.Note.ToString();
            lblIssueReason.Text = _license.IssueReasen.ToString();
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

            //return System.Drawing.Image.FromFile(imagePath);

            //// 1. Read all bytes from the file. 
            //// This opens the file, reads it, and CLOSES it immediately.
            //byte[] imageBytes = File.ReadAllBytes(imagePath);

            //// 2. Create a stream from the bytes in memory
            //MemoryStream ms = new MemoryStream(imageBytes);
            //// 3. Create the image from that memory stream
            //return System.Drawing.Image.FromStream(ms);
        }
    }
}
