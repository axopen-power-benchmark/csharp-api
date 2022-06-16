using csharp_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace csharp_api.Infrastructure.Database.Configuration
{
    public class OuvrierConfiguration : IEntityTypeConfiguration<Ouvrier>
    {
        public void Configure(EntityTypeBuilder<Ouvrier> builder)
        {
            builder.HasOne(c => c.Chantier).WithMany(e => e.Ouvriers).HasForeignKey(c => c.NumeroChantier);
            builder.HasOne(c => c.User).WithMany(e => e.Ouvriers).HasForeignKey(c => c.MatriculeUser);
        }
    }
}
