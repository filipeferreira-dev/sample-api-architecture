using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.CrossCutting.DependenceInjection
{
    public class DependencyInjectorConfiguration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
