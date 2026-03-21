using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;
using DVLD__Data_Tier.Repositories;

namespace DVLD__Business_Tier.Services
{
    public class LicenseClassService
    {
        private LicenseClassRepository _repository;
        public LicenseClassService()
        {
            _repository = new LicenseClassRepository();
        }
        public  async Task<List<LicenseClass>> GetAlllicenseClasses()
        {
            List<LicenseClass> list = await _repository.GetAllLicenseClasses();
			return list;
        }
    }
}
