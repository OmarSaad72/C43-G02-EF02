using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    public class Std_Course
    {
        [ForeignKey(nameof(Student))]
        public int StdId { get; set; }
        [ForeignKey(nameof(Course))]
        public int CrsId { get; set; }
        public int Grade { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
