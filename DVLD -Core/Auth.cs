using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;
using static DVLD__Core.Auth;

namespace DVLD__Core
{
    public static class Auth
    {
        public enum enOperations : long
        {
            FullPermission = -10001,
            PeopleList = 1,
            AddPerson = 2,
            ShowPersonDetails = 4,
            EditePersonInforamtio = 8,
            DeletePerson = 16,
            SendEmail = 32,
            PhoneCall = 64,
            UsersList = 256,
            UpdateUserInformation = 512,
            AddUser = 1024,
            DeleteUser = 2048,
            ChangeUserPassword = 4096,
            UpdateTestType = 8192,
            SetTestResult = 16384,
            InternationalLicenseList = 32768,
            SeeApplicationsList = 65536,
            SeeApplicationInformation = 131072,
            EditeApplicationInformation = 262144,
            DeleteApplicationInformation = 524288,
            UpdateApplicationInformation = 1048576,
            UpdateApplicationTypes = 2097152,
            AddLocalDrivingApplication = 4194304,
            AddInternationalLicense = 8388608,
            RenewLicenseApplication = 16777216,
            ReplaceLicenseApplication = 33554432,
            ReleaseDetainedLicense = 67108864,
            RetakeTestApplication = 134217728,
            IssueLicense = 268435456,
            ShowLicense = 536870912,
            ShowPersonLicenseHistory = 1073741824,
            DetainedLicenseList = 2147483648,
            CreateInternationalLicense = 4294967296,
            DeatainLicense = 8589934592,
            DriverList = 17179869184,
            EditePermissionsButton = 34359738368,
            ManageApplicationTypes = 68719476736,
            ManageTestTypes = 137438953472,
        }   
        public static Dictionary<Role.enRoles,decimal> DataBaseRoles { get; set; }


        public static bool IsAuth(Role UserRole ,enOperations operation)
        {      
            return _checkPermission(UserRole.RoleCode, (long)operation);
        }

        public static bool IsAuth(Role.enRoles role, enOperations operation)
        {
            decimal roleCodeFromDataBase = DataBaseRoles[role]; 
            return _checkPermission(roleCodeFromDataBase, (long)operation);
        }

        private static bool _checkPermission(decimal userRoleCode,decimal OperationCode)
        {
            if (userRoleCode == (long)enOperations.FullPermission)
            {
                return true;
            }
            if ((Convert.ToInt64(OperationCode) & Convert.ToInt64(userRoleCode)) == Convert.ToInt64(OperationCode))
            {
                return true;
            }
            return false;
        }
    }
}
