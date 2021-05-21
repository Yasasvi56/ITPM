using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableT.Models
{
    class Session
    {
        public int sessionid { get; set; }
        public string tag { get; set; }
        public string sgroup { get; set; }
        public string subject { get; set; }
        public int noofstudent { get; set; }
        public int duration { get; set; }
    }
}
