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
    public class AppointmentRepository
    {
        private string _connectionString = DataBaseSettings.DataBaseConnectionString; 
        public async Task<int> AddNewTestAppoitmentAsync(TestAppointment appointment) 
        {
            int newAppointmentID = -1;
            string query = @"INSERT INTO TestAppointments
           (
            TestType_ID
           ,LocalDrivingLicenseApplication_ID
           ,AppointmentDate
           ,PaidFees
           ,CreatedByUser_ID
           ,isLocked
           ,RetakeTestApplication_ID)
            VALUES
           (
           @TestType_ID,
           @LocalDrivingLicenseApplication_ID,
           @AppointmentDate,
           @PaidFees,
           @CreatedByUser_ID,
           @isLocked,
           @RetakeTestApplication_ID);
           SELECT SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@TestType_ID", appointment.TestType_ID);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplication_ID", appointment.LocalDrivingLicenseApplication_ID);
                command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                command.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUser_ID", appointment.CreatedByUser_ID);
                command.Parameters.AddWithValue("@isLocked", appointment.isLocked);
                if (appointment.RetakeTestApplication_ID != null)
                {
                    command.Parameters.AddWithValue("@RetakeTestApplication_ID", appointment.RetakeTestApplication_ID);
                }
                else
                {
                    command.Parameters.AddWithValue("@RetakeTestApplication_ID", DBNull.Value);
                }


                try
                {
                    await conn.OpenAsync();
                    object applicationReturnedID = await command.ExecuteScalarAsync();
                    int.TryParse(applicationReturnedID.ToString(), out newAppointmentID);

                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            return newAppointmentID;
        }

        private async Task<int> _addNewTestAppoitmentTransactionalAsync(TestAppointment appointment , SqlConnection conn ,SqlTransaction transaction)
        {
            int newAppointmentID = -1;
            string query = @"INSERT INTO TestAppointments
           (
            TestType_ID
           ,LocalDrivingLicenseApplication_ID
           ,AppointmentDate
           ,PaidFees
           ,CreatedByUser_ID
           ,isLocked
           ,RetakeTestApplication_ID)
            VALUES
           (
           @TestType_ID,
           @LocalDrivingLicenseApplication_ID,
           @AppointmentDate,
           @PaidFees,
           @CreatedByUser_ID,
           @isLocked,
           @RetakeTestApplication_ID);
           SELECT SCOPE_IDENTITY();";
            using (SqlCommand command = new SqlCommand(query, conn,transaction))
            {
                command.Parameters.AddWithValue("@TestType_ID", appointment.TestType_ID);
                command.Parameters.AddWithValue("@LocalDrivingLicenseApplication_ID", appointment.LocalDrivingLicenseApplication_ID);
                command.Parameters.AddWithValue("@AppointmentDate", appointment.AppointmentDate);
                command.Parameters.AddWithValue("@PaidFees", appointment.PaidFees);
                command.Parameters.AddWithValue("@CreatedByUser_ID", appointment.CreatedByUser_ID);
                command.Parameters.AddWithValue("@isLocked", appointment.isLocked);
                if (appointment.RetakeTestApplication_ID != null)
                {
                    command.Parameters.AddWithValue("@RetakeTestApplication_ID", appointment.RetakeTestApplication_ID);
                }
                else
                {
                    command.Parameters.AddWithValue("@RetakeTestApplication_ID", DBNull.Value);
                }

               object applicationReturnedID = await command.ExecuteScalarAsync();
               int.TryParse(applicationReturnedID.ToString(), out newAppointmentID);

            }
            return newAppointmentID;
        }

        public async Task<int> AddNewRetakeTestAppoitmentAsync(TestAppointment appointment, int personID , decimal applicationTypeFees)
        {
            const int  RetakeApplicationTypeDB_ID = 7;
            ApplicationRepository applicationRepo = new ApplicationRepository();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                await conn.OpenAsync();

                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {

                        DVLD__Core.Models.Application application = new Application
                        {
                            ApplicationDate = appointment.AppointmentDate,
                            ApplicationStatus = "Completed",
                            ApplicationType_ID = RetakeApplicationTypeDB_ID,
                            CreatedByUser_ID = appointment.CreatedByUser_ID,
                            LastStatusDate = DateTime.Now,
                            Person_ID = personID,
                            PaidFees = applicationTypeFees
                        };
                        application.ApplicationID = await applicationRepo.InsertApplicationTransactional(conn, transaction, application);
                        if (application.ApplicationID == -1) { throw new Exception("Error While added Retake Application"); }

                        appointment.RetakeTestApplication_ID = application.ApplicationID;                           

                        appointment.TestAppointmentID = await _addNewTestAppoitmentTransactionalAsync(appointment, conn, transaction);
                        if (appointment.TestAppointmentID == 0 || appointment.TestAppointmentID == -1) { throw new Exception("Error While added Retake Appointment"); }



                        transaction.Commit();
                        return appointment.TestAppointmentID;
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public async Task<int> DoesApplicationHasActiveAppointmentAsync(int LDLAppID , int testType)
        {
            int foundedAppointmentID = -1;
            string query = @"select TestAppointments.TestAppointmentID from TestAppointments
                             where TestAppointments.LocalDrivingLicenseApplication_ID = @LDLAppID AND isLocked = 0 and TestType_ID = @testTypeID;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                command.Parameters.AddWithValue("@testTypeID", testType);
                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            foundedAppointmentID = reader.GetInt32(0);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return foundedAppointmentID;
        }
        public async Task<List<clsAppointmentsView>> GetAllAppointmentsAsync(int LDLApp , int testTypeID)
        {
            List<clsAppointmentsView> appsList = new List<clsAppointmentsView>();
            string query = "SELECT TestAppointmentID , AppointmentDate ,PaidFees,isLocked" +
                " FROM AppointmentsView " +
                "where LocalDrivingLicenseApplication_ID= @lDLAppID  AND TestType_ID = @testType ORDER BY TestAppointmentID DESC";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@lDLAppID",LDLApp);
                command.Parameters.AddWithValue("@testType", testTypeID);
                try
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            appsList.Add(new clsAppointmentsView
                            {
                                TestAppointmentID = (int)reader["TestAppointmentID"],
                                AppointmentDate = (DateTime)reader["AppointmentDate"],
                                PaidFees = (decimal)reader["PaidFees"],
                                isLocked = Convert.ToBoolean(reader["isLocked"])
                                
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return appsList;
        }

        public async Task<TestAppointment> GetAppointmentByIDAsync(int appointmentID)
        {
            TestAppointment appointment = null;

            string query = @"SELECT TestAppointmentID
                              ,TestType_ID
                              ,LocalDrivingLicenseApplication_ID
                              ,AppointmentDate
                              ,PaidFees
                              ,CreatedByUser_ID
                              ,isLocked
                              ,RetakeTestApplication_ID
                        FROM TestAppointments
                        WHERE TestAppointmentID = @taID ; 
                        ";

            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@taID", appointmentID);
                try
                {
                    await conn.OpenAsync();

                    using(SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            appointment = new TestAppointment
                            {
                                TestAppointmentID = (int)reader["TestAppointmentID"],
                                TestType_ID = (int)reader["TestType_ID"],
                                LocalDrivingLicenseApplication_ID = (int)reader["LocalDrivingLicenseApplication_ID"],
                                AppointmentDate = (DateTime)reader["AppointmentDate"],
                                PaidFees = (decimal)reader["PaidFees"],
                                CreatedByUser_ID = (int)reader["CreatedByUser_ID"],
                                isLocked = Convert.ToBoolean(reader["isLocked"]),                          
                            };

                            if (reader["RetakeTestApplication_ID"] == DBNull.Value)
                            {
                                appointment.RetakeTestApplication_ID = null;
                            }
                            else
                            {
                                appointment. RetakeTestApplication_ID = (int)reader["RetakeTestApplication_ID"];
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return appointment;
        }
        public async Task<bool> UpdateAppointmentDateAsync(int testAppointmentID,DateTime newDate)
        {
            bool isUpdated = false;
            string query = @"Update TestAppointments Set AppointmentDate = @AD where TestAppointmentID = @ta;";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@AD", newDate);
                command.Parameters.AddWithValue("@ta", testAppointmentID);
                try
                {
                    await conn.OpenAsync();
                    isUpdated = await command.ExecuteNonQueryAsync() > 0;

                }
                catch (Exception)
                {

                    throw;
                }

            }
            return isUpdated;
        }
        public async Task<bool> UpdateAppointmentLockStatusAsync(int testAppointmentID)
        {
            bool isUpdated = false;
            string query = @"Update TestAppointments Set isLocked =1  where TestAppointmentID = @ta;";
            using (SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ta", testAppointmentID);
                try
                {
                    await conn.OpenAsync();
                    isUpdated = await command.ExecuteNonQueryAsync() > 0;

                }
                catch (Exception)
                {

                    throw;
                }

            }
            return isUpdated;
        }
    }
}
