using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableT.Models
{
    class NotAvailableTime
    {
        public int NotAvailableTimeID { get; set; }

        public string Lecturer { get; set; }

        public string GroupID { get; set; }

        public string SubGroupID { get; set; }

        public string SessionID { get; set; }

        public string Time { get; set; }
    }
}
