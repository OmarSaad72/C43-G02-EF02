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
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> E)
        {
            E
            .Property(E => E.Name)
            .HasColumnName("EmpName")
            .HasColumnType("varchar(255)");
            E
            .Property(e => e.Code)
            .HasColumnName("EmpId")
            .UseIdentityColumn(10, 10)
            .IsRequired();
        }
    }
}
