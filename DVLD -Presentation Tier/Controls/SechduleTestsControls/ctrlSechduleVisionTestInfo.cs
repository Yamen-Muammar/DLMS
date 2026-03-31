using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD__Presentation_Tier.Controls.SechduleTestsControls
{
    public partial class ctrlSechduleVisionTestInfo : UserControl
    {
        private int _ldlAppID;
        private string _licenseClassName;
        private int _trail;
        private string _applicantFullName;
        private DateTime _date;    
        private decimal _fees;
        public ctrlSechduleVisionTestInfo()
        {
            InitializeComponent();
        }
        public ctrlSechduleVisionTestInfo
            (int LDLAppID, string licenseClassName, int tril, string applicantName, DateTime date, decimal fees)
        {
            InitializeComponent();
            _ldlAppID = LDLAppID;
            _licenseClassName = licenseClassName;
            _trail = tril;
            _applicantFullName = applicantName;
            _date = date;
            _fees = fees;
        }

        private void ctrlSechduleVisionTestInfo_Load(object sender, EventArgs e)
        {
            if (!_isProprtiesValid())
            {
                return;
            }
            _loadDateInForm();
        }

        private bool _isProprtiesValid()
        {
            if (_ldlAppID <= 0 && _licenseClassName == null && _trail < 0 && _applicantFullName == null && _date == null 
                && _fees <=  0)
            {
                return false;
            }
            return true;
        }

        private void _loadDateInForm()
        {
            try
            {
                lblLDLApp.Text = _ldlAppID.ToString();
                lblLClassName.Text = _licenseClassName.ToString();
                lblTrail.Text = _trail.ToString();
                lblName.Text = _applicantFullName.ToString();
                lblDate.Text = _date.ToString("d");
                lblFees.Text = _fees.ToString();
            }
            catch (Exception)
            {
            }
        }
    }
}
