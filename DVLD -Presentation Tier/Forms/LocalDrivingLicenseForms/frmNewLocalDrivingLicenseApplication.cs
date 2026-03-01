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

namespace DVLD__Presentation_Tier.Forms.LocalDrivingLicenseForms
{
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        private int _personID = -1; //store id from retriveing event from ctrlPersonInformationWithFilter.

        private ApplicationType _applicationType {  get; set; }
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
            _applicationType = ApplicationsTypeService.GetApplicationTypeByID(2);
            if (_applicationType == null)
            {
                MessageBox.Show("Error While geting the Application Type.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_personID == -1)
            {
                MessageBox.Show("Set A Person First", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tabControl1.SelectedTab = tbApplicationInfo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPersonInformationWithFilter1_ReturnPersonID_OnFindPerson(int PersonID)
        {
            _personID = PersonID;
        }

        private void _loadDataInForm()
        {
            lblApplicationDate.Text = DateTime.Now.ToString("d");
            lblCreatedName.Text = Global.User.Username;
            lblApplicationFees.Text = _applicationType.ApplicationTypeFees.ToString();

        }

        private void _loadLicenseClassComboBox()
        {

        }
    }
}
