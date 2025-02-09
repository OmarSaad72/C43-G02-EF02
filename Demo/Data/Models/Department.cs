using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public DateTime DateOfCreation { get; set; }

        //Works ==> 1 : M
        [InverseProperty(nameof(Employee.Department))]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>(); //   ==> Side Many

        //Manage ==> 1 : 1
        [InverseProperty(nameof(Employee.DepartmentManage))]
        public Employee Manager { get; set; } 
    }
}
