using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;

namespace DVLD__Data_Tier.Repositories
{
    public class LicenseClassRepository
    {
        public  async Task<List<LicenseClass>> GetAllLicenseClasses()
        {         
            List<LicenseClass> classesList = new List<LicenseClass>();
          
            string query = "SELECT * FROM LicenseClasses ORDER BY LicenseClassID ASC";

            using (SqlConnection connection = new SqlConnection(DataBaseSettings.DataBaseConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader =await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            classesList.Add(new LicenseClass
                            {
                                LicenseClassID = (int)reader["LicenseClassID"],
                                ClassName = (string)reader["ClassName"],
                                ClassDescription = (string)reader["ClassDescription"],
                                MinimumAllowedAge = (int)reader["MinimumAllowedAge"],
                                DefaultValidityLength = (int)reader["DefaultValidityLength"],
                                ClassFees = (decimal)reader["ClassFees"]
                               
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }           
            return classesList;
        }         
    }
}
