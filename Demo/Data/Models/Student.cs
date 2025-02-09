using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //public ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public ICollection<Std_Course> Std_Courses { get; set; } = new HashSet<Std_Course>();
    }
}
