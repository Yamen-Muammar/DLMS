using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__Presentation_Tier.Forms.TestsForms
{
    public partial class frmTakeTest : Form
    {
        public frmTakeTest()
        {
            InitializeComponent();
        }
        public frmTakeTest(int LDLAppID, string licenseClassName, int tril, string applicantName, DateTime date, decimal fees)
        {
            InitializeComponent(LDLAppID, licenseClassName, tril, applicantName, date, fees);
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
