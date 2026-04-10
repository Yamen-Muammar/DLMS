using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Core.View_Models
{
    public class clsDriversView
    {
        public int DriverID { get; set; }
        public int Person_ID { get; set; }
        public string NationalNO { get; set; }
        public string FullName { get; set; }
        public DateTime CreationDate { get; set; }
        public int ActiveLicenses { get; set; }
    }
}
