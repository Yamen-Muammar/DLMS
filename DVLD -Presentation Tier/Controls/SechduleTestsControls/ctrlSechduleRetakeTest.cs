using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Business_Tier.Services;
using DVLD__Core.Models;

namespace DVLD__Presentation_Tier.Controls.SechduleTestsControls
{
    public partial class ctrlSechduleRetakeTest : UserControl
    {
        private const int _applicationTypeIDinDataBase = 7;
        private decimal _testTypeFees;
        private ApplicationType _applicationTypeInfo;
        private ApplicationsTypeService _applicationsTypeService;

        public ctrlSechduleRetakeTest()
        {
            InitializeComponent();
            _applicationsTypeService = new ApplicationsTypeService();
        }
        private async void ctrlSechduleRetakeTest_Load(object sender, EventArgs e)
        {

            _applicationTypeInfo = await _getApplicationTypeInfo();
            if (_applicationTypeInfo == null)
            {
                return;
            }
            _loadDataInCtrl();
        }
        public void UpdateTestTypeFees(decimal newFees)
        {
            _testTypeFees = newFees;
            lblTotalFees.Text = _calculateTotalFee().ToString("C");
        }
        public void UpdateApplicationTypeID(int newRetakeApplicationID)
        {
            lblRAppID.Text = newRetakeApplicationID.ToString();
        }
        

        private async Task<ApplicationType> _getApplicationTypeInfo()
        {
            try
            {
                return await _applicationsTypeService.GetApplicationTypeByID(_applicationTypeIDinDataBase);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Retrieving Application Type Data. : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        private void _loadDataInCtrl()
        {
            lblRAppFees.Text = _applicationTypeInfo.ApplicationTypeFees.ToString("C");
            lblTotalFees.Text = _calculateTotalFee().ToString("C");
        }       
        private decimal _calculateTotalFee()
        {
            return _applicationTypeInfo.ApplicationTypeFees + _testTypeFees;
        }
    }
}
