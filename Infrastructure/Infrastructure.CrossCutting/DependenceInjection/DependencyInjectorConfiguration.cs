using Application.Services.Implementations;
using Application.Services.Interfaces;
using Domain.Services.Implementation.EntityServices;
using Domain.Services.Interfaces.EntityServices;
using Domain.Services.Interfaces.Repository;
using Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.CrossCutting.DependenceInjection
{
    public class DependencyInjectorConfiguration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IProductApplicationService, ProductApplicationService>();

            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddScoped<IProductEntityService, ProductEntityService>();
        }
    }
}
