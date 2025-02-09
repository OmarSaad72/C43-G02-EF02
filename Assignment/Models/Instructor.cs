using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public double Bonus { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public ICollection<Course_Inst> Courses { get; set; } = new HashSet<Course_Inst>();
        public Department? Department { get; set; }
        [ForeignKey(nameof(Department))]
        public int? DeptId { get; set; }

    }
}
