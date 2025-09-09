using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session01.Data.Models
{
    internal class Course
    {
        [Key]
        public int ID { get; set; }
        public int Duration { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }
        public int Top_ID { get; set; }
        public Topic? Topic { get; set; }

        public ICollection<Stud_Course> stud_Courses { get; set; }
        public ICollection<Course_Inst> Course_Instructors { get; set; }

    }
}
