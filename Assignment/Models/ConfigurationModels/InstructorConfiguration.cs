using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ConfigurationModels
{
    internal class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder
               .HasKey(x => x.Id);
            builder
            .Property(i => i.Id)
            .UseIdentityColumn(100, 10)
            .IsRequired();
            builder
                .Property(n => n.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(15);
            builder
                .Property(n => n.Address)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);
            builder
                .Property(n => n.Salary)
                .IsRequired()
                .HasColumnType("decimal(15,4)");
            builder
                .Property(n => n.HourRate)
                .IsRequired()
                .HasColumnType("decimal");
            builder
                .Property(n => n.Bonus)
                .IsRequired();
        }
    }
}
