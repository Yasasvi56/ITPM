using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableT.Models
{
    class Sessions
    {
        public int sessionsID { get; set; }
        public string lecturer1 { get; set; }
        public string lecturer2 { get; set; }
        public string subjectCode { get; set; }
        public string subject { get; set; }
        public string groupId { get; set; }
        public string relatedTag { get; set; }
    }
}
