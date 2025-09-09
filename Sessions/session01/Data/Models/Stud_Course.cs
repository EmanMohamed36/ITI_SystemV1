using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session01.Data.Models
{
    internal class Stud_Course
    {
        public int stud_ID { get; set; }
        public Student? Student { get; set; }
        public int Course_ID { get; set; }

        public Course? Course { get; set; }
        public string Grade { get; set; }
    }
}
