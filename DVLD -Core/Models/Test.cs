using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD__Core.Models
{
    public class Test
    {
        public int TestID { get; set; }
        public int TestAppointment_ID { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUser_ID { get; set; }

        public Test(int id , int appointmentID , bool testResult , string notes , int createdByUser_ID)
        {
            TestID = id;
            TestAppointment_ID = appointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUser_ID = createdByUser_ID;  
        }
        public Test(int appointmentID, bool testResult, string notes, int createdByUser_ID)
        {
            TestID =-1;
            TestAppointment_ID = appointmentID;
            TestResult = testResult;
            Notes = notes;
            CreatedByUser_ID = createdByUser_ID;
        }
    }
}
