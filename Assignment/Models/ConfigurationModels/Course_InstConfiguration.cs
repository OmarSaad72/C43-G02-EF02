using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ConfigurationModels
{
    internal class Course_InstConfiguration : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder
            .HasKey(n => new
            {

                n.Inst_Id,
                n.Cousre_Id
            });
            builder
                .Property(e => e.Evaluate)
                .IsRequired();
        }
    }
}
