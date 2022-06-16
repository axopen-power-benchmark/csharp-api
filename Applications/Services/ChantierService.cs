using csharp_api.Applications.Base;
using csharp_api.Infrastructure.Repository.Interfaces;
using csharp_api.Models;
using Services.Interfaces;

namespace csharp_api.Applications.Services
{
    public class ChantierService : BaseService<IChantierRepository, Chantier>, IChantierService
    {
        public ChantierService(IChantierRepository repository) : base(repository)
        {
        }

        public Task<Chantier> FindChantier(int Numero)
        {
            return _repository.Find(Numero);
        }

        public Task<Chantier> UpdateChantier(int Numero)
        {
            return _repository.Update(Numero);
        }
    }
}
