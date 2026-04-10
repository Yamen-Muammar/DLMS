using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier.Services;
using DVLD__Core.View_Models;

namespace DVLD__Presentation_Tier.Controls.LicenseControls
{
    public partial class ctrlDriverLicensesHistory : UserControl
    {
        private LicenseService _licenseService;
        private int _personID;

        enum enMode
        {
            Pass =1 , NotPass =2,
        }
        private enMode _mode;
        public ctrlDriverLicensesHistory()
        {
            InitializeComponent();
            _mode = enMode.NotPass;
        }

        private void ctrlDriverLicensesHistory_Load(object sender, EventArgs e)
        {
        }
        public void SetPersonID(int personID)
        {
            _personID = personID;
            _mode = enMode.Pass;
            tabControl1_SelectedIndexChanged(tabControl1, new EventArgs());
        }

        private async Task<List<clsLicenseHistoryView>> _getLocalLicenseData()
        {
            _licenseService = new LicenseService();
            try
            {
                return await _licenseService.GetAllLocalLicenseForPerson(_personID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<clsLicenseHistoryView>();
            }
        }

        private async void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpLocal)
            {
                dgvLocalLicense.DataSource = await _getLocalLicenseData();
            }
            else
            {
                // TODO: Implement fetching and displaying international license data when the international tab is selected.
            }

        }
      
    }
}
