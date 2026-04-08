using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__Presentation_Tier.Forms.LocalDrivingLicenseForms
{
    public partial class frmApplicationInformation : Form
    {
        public frmApplicationInformation()
        {
            InitializeComponent();
        }

        public frmApplicationInformation(int ldlAppID)
        {
            InitializeComponent(ldlAppID);
        }
    }
}
