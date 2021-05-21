using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableT.Models
{
    class Subject
    {
        public int subjectid { get; set; }
        public string offeredyear { get; set; }
        public int lecturehours { get; set; }
        public int offeredsemester { get; set; }
        public int tutorialhours { get; set; }
        public string subjectname { get; set; }
        public int labhours { get; set; }
        public string subjectcode { get; set; }
        public int evoluationhours { get; set; }
    }
}
