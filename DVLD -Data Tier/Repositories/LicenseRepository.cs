using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core;
using DVLD__Core.Models;

namespace DVLD__Data_Tier.Repositories
{
    public class LicenseRepository
    {
        private readonly string _connectionString = DataBaseSettings.DataBaseConnectionString;

        public async Task<int> InsertNewLicenseForFirstTimeAsync(DVLD__Core.Models.Application application, DVLD__Core.Models.License newLicense)
        {
            int insertedLicenseID = -1;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                // 1. Begin the Titanium Shield: The SQL Transaction
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // ==========================================
                        // STEP 1: INSERT DRIVER
                        // ==========================================
                        Driver newDriver = new Driver(application.Person_ID, Global.User.UserID, newLicense.IssueDate);

                        newLicense.Driver_ID = await _insertNewDriverForTransactionalAsync(newDriver, transaction, connection);
                        if (newLicense.Driver_ID <= 0)
                        {
                            throw new Exception("Failed to insert new Driver.");
                        }

                        // ==========================================
                        // STEP 2: INSERT LICENSE
                        // ==========================================
                        insertedLicenseID = await _insertNewLicenseForTransactionalAsync(newLicense, transaction, connection);

                        if (insertedLicenseID <= 0)
                        {
                            throw new Exception("Failed to insert new License.");
                        }
                        // ==========================================
                        // STEP 3: UPDATE APPLICATION STATUS TO 'COMPLETED'
                        // ==========================================

                        if (! await _updateApplicationStatusToCompletedForTransactionalAsync(application.ApplicationID,transaction,connection))
                        {
                            throw new Exception("Failed to update Application status to Completed.");
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }

            return insertedLicenseID;
        }

        private async Task<int> _insertNewDriverForTransactionalAsync(DVLD__Core.Models.Driver newDriver, SqlTransaction transaction, SqlConnection connection)
        {
            DriverRepository driverRepository = new DriverRepository();

            return
                 await driverRepository.InsertNewDriverForTransactionalAsync(newDriver, transaction, connection);
        }

        private async Task<int> _insertNewLicenseForTransactionalAsync(DVLD__Core.Models.License newLicense, SqlTransaction transaction, SqlConnection connection)
        {
            int insertedLicenseID = -1;
            string insertLicenseQuery = @"
                            INSERT INTO Licenses 
                            (Driver_ID, IssueDate, IssueReasen, Note, isActive, ExpirationDate, CreateByUser_ID, LocalDrivingLicenseApplication_ID)
                            VALUES 
                            (@Driver_ID, @IssueDate, @IssueReasen, @Note, @isActive, @ExpirationDate, @LicenseCreatedBy, @LDLApp_ID);
                            SELECT SCOPE_IDENTITY();";
            using (SqlCommand cmdLicense = new SqlCommand(insertLicenseQuery, connection, transaction))
            {
                cmdLicense.Parameters.AddWithValue("@Driver_ID", newLicense.Driver_ID);
                cmdLicense.Parameters.AddWithValue("@IssueDate", newLicense.IssueDate);
                cmdLicense.Parameters.AddWithValue("@IssueReasen", newLicense.IssueReasen);
                cmdLicense.Parameters.AddWithValue("@isActive", newLicense.isActive);
                cmdLicense.Parameters.AddWithValue("@ExpirationDate", newLicense.ExpirationDate);
                cmdLicense.Parameters.AddWithValue("@LicenseCreatedBy", newLicense.CreateByUser_ID);
                cmdLicense.Parameters.AddWithValue("@LDLApp_ID", newLicense.LocalDrivingLicenseApplication_ID);

                if (string.IsNullOrWhiteSpace(newLicense.Note))
                    cmdLicense.Parameters.AddWithValue("@Note", DBNull.Value);
                else
                    cmdLicense.Parameters.AddWithValue("@Note", newLicense.Note);

                object licenseResult = await cmdLicense.ExecuteScalarAsync();
                if (licenseResult != null && int.TryParse(licenseResult.ToString(), out int generatedLicenseID))
                {
                    insertedLicenseID = generatedLicenseID;
                }
            }
            return insertedLicenseID;
        }

        private async Task<bool> _updateApplicationStatusToCompletedForTransactionalAsync(int applicationID, SqlTransaction transaction, SqlConnection connection)
        {
            ApplicationRepository applicationRepository = new ApplicationRepository();
            if (await applicationRepository.UpdateApplicationStatusTransactionalAsync(connection, transaction, "Completed", applicationID))
            {
                return true;
            }
            return false;
        }
    }
}
