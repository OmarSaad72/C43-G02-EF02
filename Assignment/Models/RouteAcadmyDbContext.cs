using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models
{
    internal class RouteAcadmyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.;Database= Route; Trusted_Connection= true; trustservercertificate= true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            #region M : M
            #region Std_Course
            //modelBuilder.Entity<Std_Course>()
            //    .HasKey(k => new
            //    {
            //        k.StudId,
            //        k.CourseId
            //    });
            #endregion
            #region Course_Inst
            //modelBuilder.Entity<Course_Inst>()
            //   .HasKey(k => new
            //   {
            //       k.Cousre_Id,
            //       k.Inst_Id
            //   });
            #endregion
            #endregion
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
