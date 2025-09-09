using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session01.Data.Models
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public Instructor? Instructor { get; set; }
        
        public DateTime HiringDat { get; set; }
        
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }

    }
}
