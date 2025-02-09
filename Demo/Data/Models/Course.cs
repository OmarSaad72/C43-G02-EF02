using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Std_Course> Std_Courses { get; set; } = new HashSet<Std_Course>();

    }
}
