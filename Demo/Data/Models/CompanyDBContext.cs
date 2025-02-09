using Demo.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class CompanyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .;Database= Company;Trusted_Connection=true;trustservercertificate=true");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region DepartmentConfigurationRelation
            //modelBuilder.Entity<Department>()
            //    .HasMany(d => d.Employees) // Represented Relation Of Many
            //    .WithOne(e => e.Department) // Represented Relation Of One
            //    ////###.HasForeignKey(e => e.DeptId);
            #endregion

            #region EmployeeConfigurationRelation
            //modelBuilder.Entity<Employee>()
            //    .HasOne(e => e.Department) // Represented Relation Of Many
            //    .WithMany(d => d.Employees) // Represented Relation Of One
            //    .HasForeignKey(e => e.DeptId);
            #endregion
            //modelBuilder.Entity<Employee>().Property(nameof(Employee.Name));
            //modelBuilder.Entity<Employee>().Property("Name");
            #region OverLoad EFCore 01
            ////modelBuilder.Entity<Employee>().ToTable("Employees", "dbo");  //instead of ==> public DbSet<Employee> Employees { get; set; } 
            //modelBuilder.Entity<Employee>()
            // .Property(E => E.Name)
            //.IsRequired()
            //.HasDefaultValue("Name");
            //modelBuilder.Entity<Employee>()
            //.Property(e => e.Code)
            //.UseIdentityColumn(10, 10)
            //.HasAnnotation("MaxLength", "50");
            #endregion

            #region OverLoad EFCore 3.1
            //modelBuilder.Entity<Employee>(E =>
            //{
            //    E
            //    .Property(E => E.Name)
            //    .IsRequired()
            //    .HasDefaultValue("Name");
            //    E
            //    .Property(e => e.Code)
            //    .UseIdentityColumn(10, 10);
            //    //.HasAnnotation("MaxLength", "50");
            //});
            #endregion

            //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Aplly All Congiguration Classes
        }
    }
}
