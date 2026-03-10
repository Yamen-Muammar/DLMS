using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Core.Models
{
    public class Application
    {
        public int ApplicationID { get; set; }
        public int CreatedByUser_ID { get; set; }
        public int ApplicationType_ID { get; set; }
        public int Person_ID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public decimal PaidFees { get; set; }        
        public DateTime? LastStatusDate { get; set; }
        public string ApplicationStatus 
        { 
            get
            {
                return ApplicationStatus;
            }
            set
            {
                if (!_isStatusValid(value))
                {
                    throw new ArgumentException("Status Must be one of these (New , Canceled,Completed)");
                }

                ApplicationStatus = value;
            
            } 
        }
        

        private bool _isStatusValid(string enteredstatus)
        {
            if (string.IsNullOrEmpty(enteredstatus)) { return false; }

            if(enteredstatus != "New" || enteredstatus != "Canceled"|| enteredstatus != "Completed")
            {
                return false; 
            }
            return true;

        }
    }
}
