using csharp_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace csharp_api.Infrastructure.Database.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(c => c.Chantier).WithMany(e => e.Users).HasForeignKey(c => c.NumeroLatestChantier);
        }
    }
}
