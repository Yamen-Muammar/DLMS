using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;
using DVLD__Data_Tier.Repositories;

namespace DVLD__Business_Tier.Services
{
    public class TestTypeService
    {
        public static TestType Find(int id)
        {
            TestType testType = TestTypesRepository.GetTestTypeByID(id);
            
            return testType;
        }

        public static bool UpdateTestType(TestType testType)
        {
            if (!_validateTestType(testType))
            {
                return false;
            }
            
            if (!TestTypesRepository.UpdateTestType(testType))
            {
                throw new Exception("Can not update the test type. Please try again later.");
            }
            return true;
        }
        public static List<TestType> GetAllTestTypes()
        {
            List<TestType> testTypes; 

            testTypes = TestTypesRepository.GetAllTestTypes();
            
            return testTypes;
        }
        private static bool _validateTestType(TestType testType)
        {
            if (testType == null)
            {
                throw new ArgumentNullException(nameof(testType), "TEST type cannot be null.");
            }
            if (string.IsNullOrWhiteSpace(testType.TestTypeTitle))
            {
                throw new ArgumentException("TEST type title cannot be empty.", nameof(testType));
            }
            if (testType.TestTypeFees < 0)
            {
                throw new ArgumentException("TEST type fees cannot be negative.", nameof(testType));
            }
            return true;
        }


    }
}
