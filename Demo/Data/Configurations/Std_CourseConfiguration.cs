using Demo.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Configurations
{
    internal class Std_CourseConfiguration : IEntityTypeConfiguration<Std_Course>
    {
        public void Configure(EntityTypeBuilder<Std_Course> builder)
        {
            builder
                .HasKey(k => new
                {
                    k.StdId,
                    k.CrsId
                }); //Composite PK
            builder
                .Property(g => g.Grade)
                .IsRequired()
                .HasColumnName("Std_CrsGrade");
        }
    }
}
