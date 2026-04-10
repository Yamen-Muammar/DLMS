using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;
using DVLD__Core.View_Models;

namespace DVLD__Data_Tier.Repositories
{
    public class DriverRepository
    {
        private readonly string _connectionString = DataBaseSettings.DataBaseConnectionString;

        public async Task<int> InsertNewDriverForTransactionalAsync(DVLD__Core.Models.Driver newDriver , SqlTransaction transaction , SqlConnection connection)
        {
            int insertedDriverID = -1;
            string insertDriverQuery = @"
                            INSERT INTO Drivers (Person_ID, CreatedByUser_ID, CreationDate)
                            VALUES (@Person_ID, @DriverCreatedBy, @CreationDate);
                            SELECT SCOPE_IDENTITY();";

            using (SqlCommand cmdDriver = new SqlCommand(insertDriverQuery, connection, transaction))
            {
                cmdDriver.Parameters.AddWithValue("@Person_ID", newDriver.Person_ID);
                cmdDriver.Parameters.AddWithValue("@DriverCreatedBy", newDriver.CreatedByUser_ID);
                cmdDriver.Parameters.AddWithValue("@CreationDate", newDriver.CreationDate);

                object driverResult = await cmdDriver.ExecuteScalarAsync();
                if (driverResult != null && int.TryParse(driverResult.ToString(), out int generatedDriverID))
                {
                    insertedDriverID = generatedDriverID;
                }
            }
            return insertedDriverID;
        }



        /// <summary>
        /// Checks if a person is already a registered Driver and returns their Driver profile.
        /// </summary>
        public async Task<Driver> GetDriverByPersonIDAsync(int personID)
        {
            Driver foundDriver = null;

            string query = "SELECT DriverID, Person_ID, CreatedByUser_ID, CreationDate FROM Drivers WHERE Person_ID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@PersonID", personID);

                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            foundDriver = new Driver
                            (
                              (int)reader["DriverID"],
                                (int)reader["Person_ID"],
                               (int)reader["CreatedByUser_ID"],
                               (DateTime)reader["CreationDate"]
                            );
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return foundDriver;
        }

        public async Task<Driver> GetDriverByIDAsync(int driverID)
        {
            Driver foundDriver = null;
            string query = "SELECT DriverID, Person_ID, CreatedByUser_ID, CreationDate FROM Drivers WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@DriverID", driverID);

                try
                {
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            foundDriver = new Driver
                            (
                              (int)reader["DriverID"],
                                (int)reader["Person_ID"],
                               (int)reader["CreatedByUser_ID"],
                               (DateTime)reader["CreationDate"]
                            );
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return foundDriver;
        }

        public async Task<List<clsDriversView>> GetAllDriversAsync() {         
            List<clsDriversView> driversList = new List<clsDriversView>();

            string query = @"select DriverID ,Person_ID, NationalNO ,FullName,CreationDate,ActiveLicenses from DriversView;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            clsDriversView driverView = new clsDriversView
                            {
                                DriverID = (int)reader["DriverID"],
                                Person_ID = (int)reader["Person_ID"],
                                NationalNO = reader["NationalNO"].ToString(),
                                FullName = reader["FullName"].ToString(),
                                CreationDate = (DateTime)reader["CreationDate"],
                                ActiveLicenses = (int)reader["ActiveLicenses"]
                            };
                            driversList.Add(driverView);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return driversList;
        }
    }
}
