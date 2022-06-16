using csharp_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_api.Infrastructure.Database.Configuration
{
    public class ChefConfiguration : IEntityTypeConfiguration<Chef>
    {
        public void Configure(EntityTypeBuilder<Chef> builder)
        {
            builder.HasKey(c => new { c.NumeroChantier, c.MatriculeUser });
            builder.HasOne(c => c.Chantier).WithMany(e => e.Chefs).HasForeignKey(e => e.NumeroChantier);
            builder.HasOne(c => c.User).WithMany(e => e.Chefs).HasForeignKey(e => e.MatriculeUser);
        }
    }
}
