using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;
using DVLD__Data_Tier.Repositories;

namespace DVLD__Business_Tier.Services
{
    public class LicenseService
    {
        LicenseRepository _licenseRepo;
        public LicenseService()
        {
            _licenseRepo = new LicenseRepository();
        }

        public async Task<int> AddLicenseFirstTimeAsync(License license)
        {
            if (!_isValid(license))
            {
                return -1;
            }
            return await _licenseRepo.InsertNewLicenseForFirstTimeAsync(license);
        }

        private bool _isValid(License license)
        {
            if (license == null)
            {
                throw new ArgumentNullException(nameof(license));
            }
            return true;
        }
    }
}
