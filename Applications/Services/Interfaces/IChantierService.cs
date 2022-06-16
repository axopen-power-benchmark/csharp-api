using csharp_api.Applications.Base;
using csharp_api.Models;

namespace Services.Interfaces
{
    public interface IChantierService : IBaseService<Chantier>
    {

        Task<Chantier> FindChantier(int Numero);
        Task<Chantier> UpdateChantier(int Numero);
    }
}
