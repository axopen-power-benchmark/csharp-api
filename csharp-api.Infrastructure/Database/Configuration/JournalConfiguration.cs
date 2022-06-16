using csharp_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace csharp_api.Infrastructure.Database.Configuration
{
    public class JournalConfiguration : IEntityTypeConfiguration<Journal>
    {
        public void Configure(EntityTypeBuilder<Journal> builder)
        {
            builder.HasOne(c => c.Chantier).WithMany(e => e.Journaux).HasForeignKey(c => c.NumeroChantier);
        }
    }
}
