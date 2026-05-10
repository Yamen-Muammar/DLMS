using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core;
using DVLD__Core.View_Models;
using DVLD__Data_Tier.Repositories;

namespace DVLD__Business_Tier.Services
{
    public class DriverService
    {
        DriverRepository _driverRepo;
        public DriverService()
        {
            _driverRepo = new DriverRepository();
        }
        public async Task<List<clsDriversView>> GetDriversListAsync()
        {
            if (!Auth.IsAuth(Global.User.Role, Auth.enOperations.DriverList))
            {
                throw new UnauthorizedAccessException("Access Denied");
            }
            return await _driverRepo.GetAllDriversAsync();
        }
    }
}
