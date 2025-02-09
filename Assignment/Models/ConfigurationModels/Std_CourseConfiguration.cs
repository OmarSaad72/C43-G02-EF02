using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ConfigurationModels
{
    internal class Std_CourseConfiguration : IEntityTypeConfiguration<Std_Course>
    {
        public void Configure(EntityTypeBuilder<Std_Course> builder)
        {
            builder
                .HasKey(n => new
                {

                    n.StudId,
                    n.CourseId

                });
            builder
                .Property(g => g.Grade)
                .IsRequired();
            //builder
            //    .HasOne(sc => sc.Student)
            //    .WithMany(sc => sc.Students)
            //    .HasForeignKey(sc => sc.StudId);
            //builder
            //    .HasOne(sc => sc.Course)
            //    .WithMany(sc => sc.Courses)
            //    .HasForeignKey(sc => sc.CourseId);
        }
    }
}
