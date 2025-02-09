using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public ICollection<Std_Course> std_Courses { get; set; } = new HashSet<Std_Course>();
        public Department? Department { get; set; }
        [ForeignKey(nameof(Student.Department))]
        public int? DeptId { get; set; }
    }
}
