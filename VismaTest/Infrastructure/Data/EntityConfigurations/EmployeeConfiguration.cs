using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VismaTest.Models;

namespace VismaTest.Infrastructure.Data.EntityConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee", "dbo");
            builder.HasKey(e => e.EmployeeId);

            builder.Property(e => e.FirstName).HasColumnName("FirstName")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.LastName).HasColumnName("LastName")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.SSN).HasColumnName("SSN")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.PhoneNumber).HasColumnName("PhoneNumber")
                .HasMaxLength(50);
        }
    }
}
