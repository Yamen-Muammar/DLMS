using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier.Services;
using DVLD__Core;

namespace DVLD__Presentation_Tier.Forms.License_Forms
{
    public partial class frmIssueDrivingLicense : Form
    {
        private DVLD__Core.Models.License _licenseInfo;
        private LicenseService _licenseService;
        private int _ldlAppID;
        public frmIssueDrivingLicense()
        {
            InitializeComponent();
        }

        public frmIssueDrivingLicense(int ldlAppID)
        {
            InitializeComponent(ldlAppID);   
            _ldlAppID = ldlAppID;
            _licenseService = new LicenseService(); 
        }

        // close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //issue button
        private async void button1_Click(object sender, EventArgs e)
        {
            if (!_validationNotes())
            {
                return;
            }

            _licenseInfo = new DVLD__Core.Models.License
            {
                LocalDrivingLicenseApplication_ID = _ldlAppID,
                IssueDate = DateTime.Now,
                IssueReasen = "Applicant Passed All The Three Tests",
                Note = tbNotes.Text,
                isActive = true,
                CreateByUser_ID = Global.User.UserID
            };

            try
            {
                _licenseInfo.LicenseID =  await _licenseService.AddLicenseAsync(_licenseInfo);
                if (_licenseInfo.LicenseID != -1)
                {
                    MessageBox.Show("License Issued Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to issue the license. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool _validationNotes()
        {
            if (string.IsNullOrWhiteSpace(tbNotes.Text))
            {
                MessageBox.Show("Please enter notes for issuing the license.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNotes.Focus();
                return false;
            }
            return true; 
        }
    }
}
