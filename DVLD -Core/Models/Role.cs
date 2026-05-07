using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Core.Models
{
    public class Role
    {
        public enum enRoles
        {
            Admin = 1,
            Manager = 2,
            Employee = 3
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public decimal RoleCode { get; set; }
    }
}
