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
    public class DepenseConfiguration : IEntityTypeConfiguration<Depense>
    {
        public void Configure(EntityTypeBuilder<Depense> builder)
        {
            builder.HasOne(c => c.Journal).WithMany(e => e.Depenses).HasForeignKey(c => c.IdJournalChantier);
            builder.HasOne(c => c.Ouvrier).WithMany(e => e.Depenses).HasForeignKey(c => c.IdOuvrierChantier);
        }
    }
}
