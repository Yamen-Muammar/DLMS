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
            if (testType == null)
            {
                throw new Exception("Cant Find Test Type");
            }
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
                throw new Exception("An error occurred while updating the test type. Please try again later.");
            }
            return true;
        }
        public static List<TestType> GetAllTestTypes()
        {
            List<TestType> testTypes;
            try
            {
                testTypes = TestTypesRepository.GetAllTestTypes();
                if (testTypes == null || testTypes.Count == 0)
                {
                    throw new Exception("No test types found.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex + " ,Please try again later.");
            }

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
