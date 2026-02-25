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
    public class ApplicationsTypesRepository
    {        
        public static bool UpdateApplicationType(ApplicationType applicationType)
        {
            int rowsAffected = 0;            
            
            string query = @"UPDATE ApplicationTypes  
                         SET ApplicationTypeTitle = @Title, 
                             ApplicationFees = @Fees
                         WHERE ApplicationTypeID = @ID";
            
            using (SqlConnection connection = new SqlConnection(DataBaseSettings.DataBaseConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@ID", applicationType.ApplicationTypeID);
                command.Parameters.AddWithValue("@Title", applicationType.ApplicationTypeTitle);
                command.Parameters.AddWithValue("@Fees", applicationType.ApplicationTypeFees);

                try
                {
                    connection.Open();
                   
                    rowsAffected = command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"***Error UpdateApplicationType  :{ex} ***");                
                    return false;
                }
            }          
            return (rowsAffected > 0);
        }
    }
}
