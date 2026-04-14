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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD__Presentation_Tier.Forms.DetainedLicenseForms
{
    public partial class frmDetainLicense : Form
    {
        public DVLD__Core.Models.License LicenseInfo { get; set; }

        private DetainedLicenseService _detainedService;
        public frmDetainLicense()
        {
            InitializeComponent();
        }
        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            _detainedService = new DetainedLicenseService();
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
                this.LicenseInfo = this.ctrlDriverLicenseInfo1.LicenseInfo;
                if (LicenseInfo.LicenseID <= 0)
                {
                    return;
                }
                if (!LicenseInfo.isActive)
                {
                    MessageBox.Show("License Is Not Active, you can not detaind it !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _toggleControls(false);

                }
                else if (await _detainedService.IsLicenseDetained(LicenseInfo.LicenseID))
                {
                    MessageBox.Show("License is Detained already, you can not Detain the license", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    _toggleControls(false);
                }
                else
                {
                    _toggleControls(true); 
                    _filldetainInfoUIForm();
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
        private async void btnDetainLicense_Click(object sender, EventArgs e)
        {
            try
            {
                DetainedLicense detainedLicense = _prepareDetainedLicenseObj();
                detainedLicense.DetainID = await _detainedService.AddDetainLicense(detainedLicense);
                if (detainedLicense.DetainID == -1)
                {
                    MessageBox.Show("Can not detain the license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("License Detained Successfully","Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _toggleControls(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void llblShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private void llblLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLicenseHistory LicenseHistory = new frmLicenseHistory(this.ctrlDriverLicenseInfo1.PersonInfo.NationalNO);
            LicenseHistory.ShowDialog();
        }

        //helper functions

        private DetainedLicense _prepareDetainedLicenseObj()
        {
            DetainedLicense detainedLicense = new DetainedLicense()
            {
                License_ID = (int)LicenseInfo.LicenseID,
                DetainDate = DateTime.Now,
                FineFees = decimal.TryParse(tbFineFees.Text, out decimal fineFees) ? fineFees : 0,
                CreatedByUser_ID = Global.User.UserID,
                isReleased = false,
                ReleaseApplication_ID = null,
                ReleaseByUser_ID= null,
                ReleaseDate = null
            };
            return detainedLicense;
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
            btnDetainLicense.Enabled = enabled;
        }
        
        private void _filldetainInfoUIForm()
        {
            lblLocalLicenseID.Text = LicenseInfo.LicenseID.ToString();
            lblCreatedBy.Text = Global.User.Username;
            lblDetaindDate.Text = DateTime.Now.ToString("d");
        }
        private bool _isUIFormValid()
        {
            if (string.IsNullOrEmpty(tbFineFees.Text))
            {
                MessageBox.Show("Please enter notes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
