using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ConfigurationModels
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
                .Property(x => x.Id)
                .UseIdentityColumn(10, 1)
                .IsRequired();
            builder
                .Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(15);
            builder
                .Property(x => x.HiringDate)
                .HasComputedColumnSql("GETDATE()");
        }
    }
}
