using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Core.Models
{
    public class InternationalLicense
    {
        public int InternationalLicenseID { get; set; }
        public int Application_ID { get; set; }
        public int LocalLicense_ID { get; set; }
        public int CreatedBy_ID { get; set; }
        public DateTime  IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }  
    }
}
