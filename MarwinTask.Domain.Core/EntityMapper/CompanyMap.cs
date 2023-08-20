using MarwinTask.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwinTask.Core.EntityMapper
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.Iin);
            builder.Property(x => x.Name);
            builder.Property(x => x.Address);
            builder.Property(x => x.Note);
        }
    }
}
