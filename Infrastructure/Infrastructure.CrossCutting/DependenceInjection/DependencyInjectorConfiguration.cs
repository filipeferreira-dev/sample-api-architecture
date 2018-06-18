using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.CrossCutting.DependenceInjection
{
    public class DependencyInjectorConfiguration
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
        }
    }
}
