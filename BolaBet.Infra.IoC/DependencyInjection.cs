using BolaBet.Domain.Interfaces;
using BolaBet.Infra.Data.Context;
using BolaBet.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BolaBet.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection DbContextDependence(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("SQLConnection"
            )));
            return services;
        }  
        public static IServiceCollection RepositoryDependence(IServiceCollection services)
        {
            services.AddScoped<IApostadorRepository, ApostadorRepository>();
            return services;
        }
        
    }
}
