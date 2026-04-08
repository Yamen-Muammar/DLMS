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
    public partial class frmIssueDrivingLicense : Form
    {
        public frmIssueDrivingLicense()
        {
            InitializeComponent();
        }

        public frmIssueDrivingLicense(int ldlAppID)
        {
            InitializeComponent();
        }

        // close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //issue button
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
