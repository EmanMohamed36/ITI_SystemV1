using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session01.Data.Models
{
    internal class Course_Inst
    {
        public int inst_ID { get; set; }
        public Instructor? Instructor { get; set; }

        public int Course_ID { get; set; }
        public Course? Course { get; set; }
        public int evaluat { get; set; }
    }
}
