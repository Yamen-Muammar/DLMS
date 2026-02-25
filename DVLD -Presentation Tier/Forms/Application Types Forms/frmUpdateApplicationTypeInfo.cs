using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__Presentation_Tier.Forms.Application_Types_Forms
{
    public partial class frmUpdateApplicationTypeInfo : Form
    {
        private int _applicationTypeID;
        public frmUpdateApplicationTypeInfo()
        {
            InitializeComponent();
        }
        public frmUpdateApplicationTypeInfo(int applicationTypeID)
        {
            InitializeComponent();
            _applicationTypeID = applicationTypeID;
        }
    }
}
