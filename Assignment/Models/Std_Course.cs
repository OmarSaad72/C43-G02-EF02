using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class Std_Course
    {
        [ForeignKey("Student")]
        public int StudId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public double Grade { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
