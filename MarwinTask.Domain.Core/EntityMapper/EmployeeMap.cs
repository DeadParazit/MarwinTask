using MarwinTask.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Core.EntityMapper
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Iin);
            builder.Property(x => x.Firstname);
            builder.Property(x => x.Lastname);
            builder.Property(x => x.Surname);
            builder.HasOne(x => x.Company).WithMany(x => x.Employees).HasForeignKey(x => x.CompanyIin);
        }
    }
}
