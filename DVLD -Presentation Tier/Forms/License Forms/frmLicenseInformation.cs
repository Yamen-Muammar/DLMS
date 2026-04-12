using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__Presentation_Tier.Forms.License_Forms
{
    public partial class frmLicenseInformation : Form
    {
        private int _LDLApplicationID;
        private string _nationalNo;
        private string _LicenseClassName;

        private int _licenseID;
        public frmLicenseInformation()
        {
            InitializeComponent();
        }
        public frmLicenseInformation(int LDLApplicationID, string nationalNo, string LicenseClassName)
        {
            InitializeComponent();
            _LDLApplicationID = LDLApplicationID;
            _nationalNo = nationalNo;
            _LicenseClassName = LicenseClassName;
        }

        public frmLicenseInformation(int licenseID)
        {
            InitializeComponent();
            _licenseID = licenseID;
        }

        private async void frmLicenseInformation_Load(object sender, EventArgs e)
        {
            if (_LDLApplicationID != 0)
            {
                await this.ctrlDriverLicenseInfo1.LoadDate(_LDLApplicationID, _nationalNo, _LicenseClassName);
            }
            else
            {
                await this.ctrlDriverLicenseInfo1.LoadDate(_licenseID);
            }
            
        }
    }
}
