using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableT.Models
{
    class WorkingDateAndTime
    {
        public int WorkingDateAndTimeID { get; set; }
        
        public String EmployeeID { get; set; }

        public String EmployeeName { get; set; }

        public String StartDate  { get; set; }

        public String EndDate { get; set; }
    }
}
