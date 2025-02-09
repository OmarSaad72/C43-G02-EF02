using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string? Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Std_Course> Courses { get; set; } = new HashSet<Std_Course>();
        public ICollection<Course_Inst> Course_Inst { get; set; } = new HashSet<Course_Inst>();
        public ICollection<Topic> Topic { get; set; } = new HashSet<Topic>();
        public int TopId { get; set; }
    }
}
