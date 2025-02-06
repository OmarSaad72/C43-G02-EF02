using Demo.Data.Configurations;
using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data
{
    internal class CompanyDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= .;Database= Company;Trusted_Connection=true;trustservercertificate=true");
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

            modelBuilder.ApplyConfiguration<Employee>(new EmployeeConfigurations());
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Aplly All Congiguration Classes
        }
    }
}
