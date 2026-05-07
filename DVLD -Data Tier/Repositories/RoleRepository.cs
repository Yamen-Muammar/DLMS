using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD__Core.Models;

namespace DVLD__Data_Tier.Repositories
{
    public class RoleRepository
    {
        private string _connectionString;
        public RoleRepository()
        {
            _connectionString = DataBaseSettings.DataBaseConnectionString;
        }

        public async Task<List<Role>> GetAllRoles()
        {
            List<Role> roles = new List<Role>();
            try
            {
                string query = "SELECT RoleID ,RoleName,RoleCode FROM Roles";

                using (SqlConnection conn = new SqlConnection(_connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            Role role = new Role
                            {
                                RoleId = (int)reader["RoleID"],
                                RoleName = (string)reader["RoleName"],
                                RoleCode = (decimal)reader["RoleCode"]
                            };
                            roles.Add(role);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            
            return roles;
        }

        public async Task<bool> UpdateRoleCode(string RoleName,decimal newRoleCode)
        {
            bool isUpdated =  false;
            string query = "UPDATE Roles SET RoleCode = @RoleCode WHERE RoleName = @RoleName";
            using(SqlConnection conn = new SqlConnection(_connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@RoleName", RoleName);
                    cmd.Parameters.AddWithValue("@RoleCode", newRoleCode);

                    await conn.OpenAsync();
                    isUpdated =await cmd.ExecuteNonQueryAsync() > 0;
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
