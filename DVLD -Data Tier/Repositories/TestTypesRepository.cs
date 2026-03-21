using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;

namespace DVLD__Data_Tier.Repositories
{
    public class TestTypesRepository
    {
        public async Task<TestType> GetTestTypeByID(int testTypeID)
        {
            TestType testType = null;

            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @ID";
            using (SqlConnection connection = new SqlConnection(DataBaseSettings.DataBaseConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", testTypeID);
                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader =await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            testType = new TestType
                            {
                                TestTypeID = (int)reader["TestTypeID"],
                                 TestTypeTitle = reader["TestTypeTitle"].ToString(),
                                TestTypeDescription = reader["TestTypeDescription"].ToString(),
                                TestTypeFees = (decimal)reader["TestTypeFees"]
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return testType;
        }
        public  async Task<List<TestType>> GetAllTestTypes()
        {

            List<TestType> types = new List<TestType>();

            string query = "SELECT * FROM TestTypes ORDER BY TestTypeID ASC";
        
            using (SqlConnection connection = new SqlConnection(DataBaseSettings.DataBaseConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    await connection.OpenAsync();
                    
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            types.Add(new TestType
                            {
                                TestTypeID = (int)reader["TestTypeID"],
                                TestTypeTitle = reader["TestTypeTitle"].ToString(),
                                TestTypeDescription = reader["TestTypeDescription"].ToString(),
                                TestTypeFees = (decimal)reader["TestTypeFees"]
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return types;
        }
        public  async Task<bool> UpdateTestType(TestType testType)
        {
            int rowsAffected = 0;

            string query = @"UPDATE TestTypes 
                         SET
                            TestTypeTitle = @title,
                            TestTypeDescription = @description,
                            TestTypeFees = @Fees
                         WHERE TestTypeID = @ID";

            using (SqlConnection connection = new SqlConnection(DataBaseSettings.DataBaseConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@ID", testType.TestTypeID);
                command.Parameters.AddWithValue("@Title", testType.TestTypeTitle);
                command.Parameters.AddWithValue("@Fees", testType.TestTypeFees);
                command.Parameters.AddWithValue("@description", testType.TestTypeDescription);
                try
                {
                    await connection.OpenAsync();

                    rowsAffected =await command.ExecuteNonQueryAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return (rowsAffected > 0);
        }
    }
}
