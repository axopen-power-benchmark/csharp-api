using csharp_api.Applications.Services;
using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;

namespace csharp_api.Applications
{
    public static class DependencyInjection
    {

        public static void AddServices(this IServiceCollection services)
        {
            //Ajouter les services
            services.AddScoped<IChantierService, ChantierService>();
        }
    }
}
