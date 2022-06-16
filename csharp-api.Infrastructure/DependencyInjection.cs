using csharp_api.Infrastructure.Repository;
using csharp_api.Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace csharp_api.Infrastructure
{
    public static class DIMethods
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            //Ajouter les repository
            services.AddScoped<IChantierRepository, ChantierRepository>();
        }

    }
}
