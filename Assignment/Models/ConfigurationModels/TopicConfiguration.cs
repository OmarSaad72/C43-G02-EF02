using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Models.ConfigurationModels
{
    internal class TopicConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder
                .HasKey(x => x.Id);
            builder
            .Property(i => i.Id)
            .UseIdentityColumn()
            .IsRequired();
            builder
                .Property(n => n.Name)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(25);
        }
    }
}
