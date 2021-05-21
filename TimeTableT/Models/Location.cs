using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableT.Models
{
    class Location
    {
        public int locationID { get; set; }
        public string room { get; set; }
        public string day { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }
    
}
