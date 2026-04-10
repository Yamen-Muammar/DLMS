using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return await _driverRepo.GetAllDriversAsync();
        }
    }
}
