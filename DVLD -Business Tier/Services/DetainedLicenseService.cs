using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;
using DVLD__Data_Tier.Repositories;

namespace DVLD__Business_Tier.Services
{
    public class DetainedLicenseService
    {
        private DetainedLicenseRepository _repo;
        public DetainedLicenseService()
        {
            _repo = new DetainedLicenseRepository();
        }

        public async Task<bool> IsLicenseDetained(int licenseID)
        {
            return await _repo.IsLicenseDetained(licenseID);
        }

        public async Task<int> AddDetainLicense(DetainedLicense detainedLicense)
        {
            if (!_isDetainedValid(detainedLicense))
            {
                return -1;
            }

            if (await IsLicenseDetained(detainedLicense.License_ID))
            {
                throw new Exception("License already Detained");
            }

            return await _repo.AddNewDetainedLicenseAsync(detainedLicense);
        }

        private bool _isDetainedValid(DetainedLicense detainedLicense)
        {
            if (detainedLicense.FineFees <= 0)
            {
                throw new ArgumentException("Fine Fees must valid");
            }
            return true;
        }

        public async Task<List<DetainedLicense>> GetAllDetainedLicenses()
        {
            return await _repo.GetAllDetainedLicensesAsync();
        }

        public async Task<int> ReleaseDetainedLicenseAsync(DVLD__Core.Models.Application newApplication,DetainedLicense detainedLicense)
        {
            if (detainedLicense.DetainID <= 0 || newApplication.Person_ID <= 0)
            {
                throw new ArgumentException("Invalid Passed Data");
            }

            if (!await _repo.IsLicenseDetained(detainedLicense.License_ID))
            {
                throw new Exception("License is not Detained");
            }

            return await _repo.RelaseDetainedLicense(detainedLicense,newApplication);
        }
        public async Task<DetainedLicense> GetDetainedLicenseByLicenseIDAsync(int licenseID)
        {
            if (licenseID <= 0)
            {
                throw new ArgumentException("Invalid License ID");
            }
            return await _repo.GetDetainedInformationByLicenseIDAsync(licenseID);
        }

        public async Task<DetainedLicense> GetDetaineByIDAsync(int detaineID)
        {
            if (detaineID <= 0)
            {
                throw new ArgumentException("Invalid Detained License ID");
            }

            return await _repo.GetDetainedInformationByIDAsync(detaineID);
        }
    }
}
