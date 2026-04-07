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

namespace DVLD__Presentation_Tier.Forms.TestsAppointment.StreetTestForm
{
    public partial class frmSechduleStreetTest : Form
    {
        private int? appID;
        private ctrlSechduleStreetTest.enMode mode;
        private string applicantFullName;
        private int LDLAppID;
        private int testTypeID;
        private string licenseClassName;
        private int trail;
        public frmSechduleStreetTest()
        {
            InitializeComponent();
        }

        public frmSechduleStreetTest(int? appointmentID, ctrlSechduleStreetTest.enMode mode, string applicantFullName, int LDLAppID, int _testTypeID, string licenseClassName, int trail)
        {
            InitializeComponent();
            appID = appointmentID;
            this.mode = mode;
            this.applicantFullName = applicantFullName;
            this.LDLAppID = LDLAppID;
            this.testTypeID = _testTypeID;
            this.licenseClassName = licenseClassName;
            this.trail = trail;
            this.ctrlSechduleStreetTest1._fillUIwithPassedPrameters(appID, mode, applicantFullName, LDLAppID, licenseClassName, trail);
        }
    }
}
