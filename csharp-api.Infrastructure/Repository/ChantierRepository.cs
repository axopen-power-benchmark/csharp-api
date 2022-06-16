using csharp_api.Helpers;
using csharp_api.Infrastructure.Base;
using csharp_api.Infrastructure.Database;
using csharp_api.Infrastructure.Repository.Interfaces;
using csharp_api.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_api.Infrastructure.Repository
{
    public class ChantierRepository : BaseRepository<Chantier, CoreDbContext>, IChantierRepository
    {
        public ChantierRepository(CoreDbContext databaseContext) : base(databaseContext)
        {
        }

        public async Task<Chantier> Find(int Numero)
        {

            // Récupération Explicite
            var chantier = _dbContext.Chantiers.Single(b => b.Numero == Numero);

            _dbContext.Entry(chantier)
                .Collection(b => b.Ouvriers)
                .Load();

            _dbContext.Entry(chantier)
                .Collection(b => b.Chefs)
                .Load();

            _dbContext.Entry(chantier)
                .Collection(b => b.Users)
                .Load();

            _dbContext.Entry(chantier)
                .Collection(b => b.Journaux)
                .Query()
                .Include(item => item.Depenses)
                .Load();

            return chantier;

            /*return await _dbContext.Chantiers.Where(item => item.Numero == Numero)
                .Include(item => item.Ouvriers)
                .Include(item => item.Chefs)
                .Include(item => item.Journaux).ThenInclude(item => item.Depenses)
                .Include(item => item.Users)
                .AsSplitQuery()
                .AsNoTracking()
                .FirstOrDefaultAsync();*/
        }

        public async Task<Chantier> Update(int Numero)
        {
            Chantier chantier = await _dbContext.Chantiers.FindAsync(Numero);
            chantier.Description = RandomHelper.GetRandomString(12);
            chantier.City = RandomHelper.GetRandomString(12);
            chantier.CityCP = RandomHelper.GetRandomInt(0, 99999);
            chantier.DateDebut = new DateTime(RandomHelper.GetRandomInt(0, 2000000000));
            chantier.DateFin = new DateTime(RandomHelper.GetRandomInt(0, 2000000000));
            chantier.Status = RandomHelper.GetRandomString(12);
            chantier.LienSharepoint = RandomHelper.GetRandomString(12);
            chantier.LienFiles = RandomHelper.GetRandomString(12);
            chantier.LienGearth = RandomHelper.GetRandomString(12);
            chantier.PrixMoyenMoeJour = RandomHelper.GetRandomInt(0, 100);
            chantier.PrixMoyenMoeNuit = RandomHelper.GetRandomInt(0, 100);
            chantier.PrixMoyenMateriel = RandomHelper.GetRandomInt(0, 100);
            chantier.JournalPointageErp = RandomHelper.GetRandomString(12);

            _dbContext.Update(chantier);

            return chantier;
        }
    }
}
