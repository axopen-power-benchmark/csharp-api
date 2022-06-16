using csharp_api.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace csharp_api.Infrastructure.Database
{
    public class CoreDbContext : DbContext
    {

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        { }

        public DbSet<Chantier> Chantiers { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Depense> Depenses { get; set; }
        public DbSet<Journal> Journaux { get; set; }
        public DbSet<Ouvrier> Ouvriers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
