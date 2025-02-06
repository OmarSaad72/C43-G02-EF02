using System;
using System.Collections.Generic;
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
        public int DeptId { get; set; }
    }
}
