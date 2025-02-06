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
           .HasAlternateKey(n => new
           {

               n.StudId ,
               n.CourseId

           });
            builder
                .Property(g => g.Grade)
                .IsRequired();
        }
    }
}
