using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;

namespace DVLD__Data_Tier.Repositories
{
    public
    class DetainedLicenseRepository
    {
        private string _connectionString;
        public DetainedLicenseRepository()
        {
            _connectionString = DataBaseSettings.DataBaseConnectionString;
        }

        public async Task<bool> IsLicenseDetained(int licenseID)
        {
            bool isLicenseDetained = false;
            string query = @"
                                select 1 as Founded from DetainedLicenses
                               WHERE DetainedLicenses.license_ID = @licenseID AND DetainedLicenses.isReleased = 0 and ReleaseApplication_ID is NULL;";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@licenseID", licenseID);
                try
                {
                    await conn.OpenAsync();
                    var result = await cmd.ExecuteScalarAsync();
                    if (result != null)
                    {
                        isLicenseDetained = true;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                return isLicenseDetained;
            }
        }

        public async Task<int> AddNewDetainedLicenseAsync(DetainedLicense detainedLicense)
        {
            int insertedDetainID = -1;

            string query = @"
                INSERT INTO [dbo].[DetainedLicenses]
                           ([license_ID]
                           ,[DetainDate]
                           ,[FineFees]
                           ,[CreatedByUser_ID]
                           ,[isReleased]
                           ,[ReleaseDate]
                           ,[ReleaseByUser_ID]
                           ,[ReleaseApplication_ID])
                     VALUES
                           (@LicenseID, 
                            @DetainDate, 
                            @FineFees, 
                            @CreatedByUserID, 
                            @IsReleased, 
                            @ReleaseDate, 
                            @ReleaseByUserID, 
                            @ReleaseApplicationID);
               
                SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@LicenseID", detainedLicense.License_ID);
                command.Parameters.AddWithValue("@DetainDate", detainedLicense.DetainDate);
                command.Parameters.AddWithValue("@FineFees", detainedLicense.FineFees);
                command.Parameters.AddWithValue("@CreatedByUserID", detainedLicense.CreatedByUser_ID);
                command.Parameters.AddWithValue("@IsReleased", detainedLicense.isReleased);

                if (detainedLicense.ReleaseDate.HasValue)
                    command.Parameters.AddWithValue("@ReleaseDate", detainedLicense.ReleaseDate.Value);
                else
                    command.Parameters.AddWithValue("@ReleaseDate", DBNull.Value);

                if (detainedLicense.ReleaseByUser_ID.HasValue)
                    command.Parameters.AddWithValue("@ReleaseByUserID", detainedLicense.ReleaseByUser_ID.Value);
                else
                    command.Parameters.AddWithValue("@ReleaseByUserID", DBNull.Value);

                if (detainedLicense.ReleaseApplication_ID.HasValue)
                    command.Parameters.AddWithValue("@ReleaseApplicationID", detainedLicense.ReleaseApplication_ID.Value);
                else
                    command.Parameters.AddWithValue("@ReleaseApplicationID", DBNull.Value);

                try
                {
                    await connection.OpenAsync();

                    object result = await command.ExecuteScalarAsync();

                    if (result != null && int.TryParse(result.ToString(), out int generatedID))
                    {
                        insertedDetainID = generatedID;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return insertedDetainID;
        }

        public async Task<List<DetainedLicense>> GetAllDetainedLicensesAsync()
        {
            List<DetainedLicense> detainedLicenses = new List<DetainedLicense>();
            string query = @"
                SELECT DetainID, license_ID, DetainDate, FineFees, CreatedByUser_ID, isReleased, ReleaseDate, ReleaseByUser_ID, ReleaseApplication_ID
                FROM DetainedLicenses
                ORDER BY DetainDate DESC;";
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
                            DetainedLicense detainedLicense = new DetainedLicense
                            {
                                DetainID = reader.GetInt32(reader.GetOrdinal("DetainID")),
                                License_ID = reader.GetInt32(reader.GetOrdinal("license_ID")),
                                DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate")),
                                FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees")),
                                CreatedByUser_ID = reader.GetInt32(reader.GetOrdinal("CreatedByUser_ID")),
                                isReleased = reader.GetBoolean(reader.GetOrdinal("isReleased")),
                                ReleaseDate = reader.IsDBNull(reader.GetOrdinal("ReleaseDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ReleaseDate")),
                                ReleaseByUser_ID = reader.IsDBNull(reader.GetOrdinal("ReleaseByUser_ID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseByUser_ID")),
                                ReleaseApplication_ID = reader.IsDBNull(reader.GetOrdinal("ReleaseApplication_ID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseApplication_ID"))
                            };
                            detainedLicenses.Add(detainedLicense);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return detainedLicenses;
        }
        public async Task<int> RelaseDetainedLicense(DetainedLicense detainedLicense, DVLD__Core.Models.Application application)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                SqlTransaction transaction = connection.BeginTransaction();
                   
                    try
                    {
                        // INSERT APPLICATION
                        detainedLicense.ReleaseApplication_ID = await _insertDetainedApplication(application, connection, transaction);

                        detainedLicense.ReleaseDate = application.ApplicationDate;
                        
                        await _updateDetainedLicenseReleaseInfo(detainedLicense, connection, transaction);
                        
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                
            }

            return (int) detainedLicense.ReleaseApplication_ID;
        }

        public async Task<DetainedLicense> GetDetainedInformationByIDAsync(int detainedLicenseID)
        {
            DetainedLicense detainedLicense = null;
            string query = @"
                SELECT DetainID, license_ID, DetainDate, FineFees, CreatedByUser_ID, isReleased, ReleaseDate, ReleaseByUser_ID, ReleaseApplication_ID
                FROM DetainedLicenses
                ORDER BY DetainDate DESC;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            detainedLicense = new DetainedLicense
                            {
                                DetainID = reader.GetInt32(reader.GetOrdinal("DetainID")),
                                License_ID = reader.GetInt32(reader.GetOrdinal("license_ID")),
                                DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate")),
                                FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees")),
                                CreatedByUser_ID = reader.GetInt32(reader.GetOrdinal("CreatedByUser_ID")),
                                isReleased = reader.GetBoolean(reader.GetOrdinal("isReleased")),
                                ReleaseDate = reader.IsDBNull(reader.GetOrdinal("ReleaseDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ReleaseDate")),
                                ReleaseByUser_ID = reader.IsDBNull(reader.GetOrdinal("ReleaseByUser_ID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseByUser_ID")),
                                ReleaseApplication_ID = reader.IsDBNull(reader.GetOrdinal("ReleaseApplication_ID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseApplication_ID"))
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return detainedLicense;
        }

        public async Task<DetainedLicense> GetDetainedInformationByLicenseIDAsync(int LicenseID)
        {
            DetainedLicense detainedLicense = null;
            string query = @"
                SELECT DetainID, license_ID, DetainDate, FineFees, CreatedByUser_ID, isReleased, ReleaseDate, ReleaseByUser_ID, ReleaseApplication_ID
                FROM DetainedLicenses
                WHERE license_ID = @licID and isReleased = 0
                ORDER BY DetainDate DESC;";
            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@licID", LicenseID);
                try
                {
                    await connection.OpenAsync();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            detainedLicense = new DetainedLicense
                            {
                                DetainID = reader.GetInt32(reader.GetOrdinal("DetainID")),
                                License_ID = reader.GetInt32(reader.GetOrdinal("license_ID")),
                                DetainDate = reader.GetDateTime(reader.GetOrdinal("DetainDate")),
                                FineFees = reader.GetDecimal(reader.GetOrdinal("FineFees")),
                                CreatedByUser_ID = reader.GetInt32(reader.GetOrdinal("CreatedByUser_ID")),
                                isReleased = reader.GetBoolean(reader.GetOrdinal("isReleased")),
                                ReleaseDate = reader.IsDBNull(reader.GetOrdinal("ReleaseDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ReleaseDate")),
                                ReleaseByUser_ID = reader.IsDBNull(reader.GetOrdinal("ReleaseByUser_ID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseByUser_ID")),
                                ReleaseApplication_ID = reader.IsDBNull(reader.GetOrdinal("ReleaseApplication_ID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("ReleaseApplication_ID"))
                            };
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return detainedLicense;
        }

        // helper methods
        private async Task<int> _insertDetainedApplication(DVLD__Core.Models.Application application, SqlConnection conn, SqlTransaction transaction)
        {
            ApplicationRepository applicationRepository = new ApplicationRepository();
            return await applicationRepository.InsertApplicationTransactional(conn, transaction, application);
        }

        private async Task<bool> _updateDetainedLicenseReleaseInfo(DetainedLicense detainedLicense, SqlConnection conn, SqlTransaction transaction)
        {
            string query = @"
                UPDATE DetainedLicenses
                SET isReleased = 1,
                    ReleaseDate = @releaseDate,
                    ReleaseByUser_ID = @ReleaseByUserID,
                    ReleaseApplication_ID = @ReleaseApplicationID
                WHERE DetainID = @DetainID;";
            using (SqlCommand command = new SqlCommand(query, conn, transaction))
            {
                command.Parameters.AddWithValue("@ReleaseByUserID",(int) detainedLicense.ReleaseByUser_ID);
                command.Parameters.AddWithValue("@releaseDate", detainedLicense.ReleaseDate);
                command.Parameters.AddWithValue("@ReleaseApplicationID", (int)detainedLicense.ReleaseApplication_ID);
                command.Parameters.AddWithValue("@DetainID", detainedLicense.DetainID);
                int rowsAffected = await command.ExecuteNonQueryAsync();
                return rowsAffected > 0;
            }
        }
    }
}


