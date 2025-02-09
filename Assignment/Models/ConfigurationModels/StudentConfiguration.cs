//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment.Models.ConfigurationModels
//{
//    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
//    {
//        public void Configure(EntityTypeBuilder<Student> builder)
//        {
//            builder
//                .HasKey(x => x.Id);
//            builder
//            .Property(i => i.Id)
//            .UseIdentityColumn(10, 10)
//            .IsRequired();
//            builder
//                .Property(n => n.FName)
//                .IsRequired()
//                .HasColumnType("varchar")
//                .HasMaxLength(15);
//            builder
//                .Property(n => n.LName)
//                .IsRequired()
//                .HasColumnType("varchar")
//                .HasMaxLength(15);
//            builder
//                .Property(n => n.Address)
//                .HasColumnType("nvarchar")
//                .IsRequired();
//        }
//    }
//}
