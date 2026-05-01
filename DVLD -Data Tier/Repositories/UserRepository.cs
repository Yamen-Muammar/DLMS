using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core;
using DVLD__Core.Models;
using DVLD__Core.View_Models;

namespace DVLD__Data_Tier.Repositories
{    
    public class UserRepository
    {
        private string connectionString = DataBaseSettings.DataBaseConnectionString;

        // ---------------------------------------------------------
        // 1. CREATE (Insert New User)
        // ---------------------------------------------------------
        public async Task<int> AddNewUser(User user)
        {
            int newUserID = -1;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Users 
                            (Username, HashedPassword,isActive, Person_ID)
                            VALUES 
                            (@username, @hashedPassword,@isActive, @personID);
                            SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@hashedPassword", user.HashedPassword);
                    cmd.Parameters.AddWithValue("@isActive", user.isActive);
                    cmd.Parameters.AddWithValue("@personID", user.Person_ID);                    
                    try
                    {
                        await conn.OpenAsync();
                        object result =await cmd.ExecuteScalarAsync();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            newUserID = insertedID;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return newUserID;
        }

        // ---------------------------------------------------------
        // 2. READ (Get User)
        // ---------------------------------------------------------
        public  async Task<User> GetUserByID(int userID)
        {
            User foundUser = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Users WHERE UserID = @userID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);

                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader =await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                foundUser = new User
                                {
                                    UserID = (int)reader["UserID"],
                                    Username = reader["Username"].ToString(),
                                    HashedPassword = reader["HashedPassword"].ToString(),
                                    Person_ID = (int)reader["Person_ID"],
                                    isActive = (bool)reader["isActive"],
                                };
                            }
                        }
                    }
                    catch (Exception)
                    { 
                        throw;
                    }
                }
            }
            return foundUser;
        }
        public async  Task<User> GetUserByUsername(string username)
        {
            User foundUser = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID,Person_ID,Username,HashedPassword,isActive FROM Users WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    try
                    {
                        await conn.OpenAsync();

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                foundUser = new User
                                {
                                    UserID = (int)reader["UserID"],
                                    Person_ID = (int)reader["Person_ID"],
                                    Username = reader["Username"].ToString(),
                                    HashedPassword = reader["HashedPassword"].ToString(),
                                    isActive = (bool)reader["isActive"],
                                };
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return foundUser;
        }

        // ---------------------------------------------------------
        // 3. READ ALL (Get List of Users)
        // ---------------------------------------------------------                        
        public  async Task<List<clsUserView>> GetAllUser()
        {
            List<clsUserView> usersList = new List<clsUserView>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from UsersView";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader =await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                usersList.Add(new clsUserView
                                {
                                    UserID = (int)reader["UserID"],
                                    UserName = reader["UserName"].ToString(),
                                    FullName = reader["FullName"].ToString(),
                                    isActive = (bool)reader["isActive"]

                                });
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }

            return usersList;
        }
        // ---------------------------------------------------------
        // 4. UPDATE (Update Existing User)
        // ---------------------------------------------------------
        public async Task<bool> UpdateUser(int userID,string newHashedPassword)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Users 
                            SET 
                            HashedPassword = @hashedPassword
                            WHERE UserID = @userID;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@hashedPassword", newHashedPassword);
                    
                    cmd.Parameters.AddWithValue("@userID", userID);

                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected =await cmd.ExecuteNonQueryAsync();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public async Task<bool> UpdateUser(int userID, bool isActive)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Users 
                            SET  
                                isActive = @isActive
                            WHERE UserID = @userID;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    cmd.Parameters.AddWithValue("@userID", userID);

                    try
                    {
                        await conn.OpenAsync();
                        rowsAffected = await cmd.ExecuteNonQueryAsync();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return (rowsAffected > 0);
        }

        // ---------------------------------------------------------
        // 5. DELETE (Delete User)
        // ---------------------------------------------------------
        public async Task<bool> DeleteUser(int userID)
        {
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE UserID = @userID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userID);

                    try
                    {
                        await conn.OpenAsync();

                        rowsAffected =await cmd.ExecuteNonQueryAsync();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return (rowsAffected > 0);
        }

        // ---------------------------------------------------------
        // 6. CHECK EXISTENCE (Is User Exists)
        // ---------------------------------------------------------
        public async Task<bool> IsUserExist(int userId)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Found=1 FROM Users WHERE UserID = @userID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@userID", userId);

                    try
                    {
                        await conn.OpenAsync();
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return isFound;
        }
        public async Task<bool> IsUserExistOnPersonID(int personId)
        {
            bool isFound = false;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Found=1 FROM Users WHERE Person_ID = @personid";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@personid", personId);

                    try
                    {
                        await conn.OpenAsync();

                        using (SqlDataReader reader =await cmd.ExecuteReaderAsync())
                        {
                            isFound = reader.HasRows;
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return isFound;
        }
    }
}

