using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableT.Models
{
    class Tag
    {
        public int tagId { get; set; }
        public string tagName { get; set; }
        public string tagCode { get; set; }
        public string relatedTag { get; set; }
    }
}
