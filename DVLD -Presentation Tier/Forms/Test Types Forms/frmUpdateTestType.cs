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
using DVLD__Core.Models;

namespace DVLD__Presentation_Tier.Forms.Test_Types_Forms
{
    public partial class frmUpdateTestType : Form
    {
        private int _testTypeID = -1;
        private TestType _testType;
        public frmUpdateTestType()
        {
            InitializeComponent();            
        }

        public frmUpdateTestType(int testTypeID)
        {
            InitializeComponent();
            _testTypeID = testTypeID;
        }

        private void frmUpdateTestType_Load(object sender, EventArgs e)
        {
            if (!_loadTestTypeDataToObject(_testTypeID))
            {
                return;
            }
            _loadDataInForm();
        }

        private bool _loadTestTypeDataToObject(int id)
        {
            try
            {
                _testType = TestTypeService.Find(id);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }                       
        }

        private void _loadDataInForm()
        {
            lblID .Text = _testTypeID.ToString();
            tbTitle.Text = _testType.TestTypeTitle.ToString();
            tbDescription.Text =_testType.TestTypeDescription.ToString();
            tbFees.Text = _testType.TestTypeFees.ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_loadInfoToObject())
            {
                return;
            }

            try
            {
                if (TestTypeService.UpdateTestType(_testType))
                {
                    MessageBox.Show("Test Type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update Test Type. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool _loadInfoToObject()
        {
            if (!ValidateInput())
            {
                return false;
            }

            _testType.TestTypeTitle = tbTitle.Text.ToString();
            tbDescription.Text = tbDescription.Text.ToString();
            _testType.TestTypeFees = decimal.Parse(tbFees.Text);
            return
                true;
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                MessageBox.Show("Please enter the test type fees.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                MessageBox.Show("Please enter the test type fees.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbFees.Text))
            {
                MessageBox.Show("Please enter the test type fees.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!decimal.TryParse(tbFees.Text, out decimal fees) || fees < 0)
            {
                MessageBox.Show("Please enter a valid non-negative number for fees.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
           
            
            return true;
        }
    }
}
