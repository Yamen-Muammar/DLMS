using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Core.Models
{
    public class Driver
    {
        public int DriverID { get; set; }
        public int Person_ID { get; set; }
        public int CreatedByUser_ID { get; set; }
        public DateTime CreationDate { get; set; }

        public Driver(int person_ID , int creaedByUser , DateTime creationDate)
        {
            Person_ID = person_ID;
            CreatedByUser_ID = creaedByUser;
            CreationDate = creationDate;
        }
        public Driver(int driverID,int person_ID, int creaedByUser, DateTime creationDate)
        {
            DriverID = driverID;
            Person_ID = person_ID;
            CreatedByUser_ID = creaedByUser;
            CreationDate = creationDate;
        }
    }
}
