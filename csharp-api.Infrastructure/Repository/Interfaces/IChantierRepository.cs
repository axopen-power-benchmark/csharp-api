using csharp_api.Infrastructure.Base;
using csharp_api.Models;
namespace csharp_api.Infrastructure.Repository.Interfaces
{
    
    public interface IChantierRepository : IBaseRepository<Chantier>
    {
        Task<Chantier> Find(int numero);
        Task<Chantier> Update(int numero);
    }
}
