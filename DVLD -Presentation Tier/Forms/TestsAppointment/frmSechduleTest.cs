using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD__Presentation_Tier.Controls.SechduleTestsControls;

namespace DVLD__Presentation_Tier.Forms.TestsAppointment
{
    public partial class frmSechduleTest : Form
    {
        private int? appID;
        private ctrlSechduleVisionTest.enMode mode;
        private string applicantFullName;
        private int LDLAppID;
        private int testTypeID;
        private string licenseClassName;
        private int trail;
        public frmSechduleTest()
        {
            InitializeComponent();
        }
        public frmSechduleTest(int? appointmentID, ctrlSechduleVisionTest.enMode mode,string applicantFullName,int LDLAppID , int _testTypeID,string licenseClassName, int trail)
        {
            InitializeComponent();
            appID = appointmentID;
            this.mode = mode;
            this.applicantFullName = applicantFullName;
            this.LDLAppID = LDLAppID;
            this.testTypeID = _testTypeID;
            this.licenseClassName = licenseClassName;
            this.trail = trail;
            this.ctrlSechduleVisionTest1._fillUIwithPassedPrameters(appID, mode, applicantFullName, LDLAppID, licenseClassName, trail);
        }

        private void frmSechduleTest_Load(object sender, EventArgs e)
        {
            
        }
    }
}
