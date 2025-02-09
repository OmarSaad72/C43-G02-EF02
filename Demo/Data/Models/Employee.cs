using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class Employee
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] //(1,1) 
        public int Code { get; set; }
        /************************************************************/
        //[Column(TypeName = "varchar")]
        //[StringLength(50/*Max*/, MinimumLength = 30)]
        //[MinLength(50)]
        //[MaxLength(50)]
        //[Length(10, 50)] //Min , Max
        public string Name { get; set; }
        /************************************************************/
        [Column(TypeName = "nvarchar")]
        [MaxLength(200)]
        public string? Address { get; set; }
        /************************************************************/
        [Column(TypeName = "decimal(12,2)")]
        public double Salary { get; set; }
        /************************************************************/
        [Range(18, 50)]
        //[AllowedValues(20,22,32)]
        //[DeniedValues(10,17)]
        public int Age { get; set; }
        /************************************************************/
        [EmailAddress]
        public string EmailAddress { get; set; }
        /************************************************************/
        [Phone]
        public string? Phone { get; set; }
        /************************************************************/
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /******************************Department Relation (Work 1: M)******************************/
        [InverseProperty(nameof(Models.Department.Employees))]
        public Department Department { get; set; } //Navigational Property ==> One Side
        [ForeignKey(nameof(Employee.Department))]
        public int? DeptId { get; set; }
        /******************************Department Relation (Manage 1: 1)******************************/
        [InverseProperty(nameof(Models.Department.Manager))]
        public Department? DepartmentManage { get; set; }
        [ForeignKey(nameof(DepartmentManage))]
        public int? DeptManageId { get; set; }

    }
}
