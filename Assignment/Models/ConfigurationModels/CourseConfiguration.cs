using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ConfigurationModels
{
    internal class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder
            .HasKey(x => x.Id);
            builder
            .Property(i => i.Id)
            .UseIdentityColumn(20, 1);
            builder
                .Property(n => n.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(15);
            builder
            .Property(n => n.Duration)
                .IsRequired();
        }
    }
}
