using ClassLibrary.DAL;
using ClassLibrary.DAL.Interfaces;
using DealerApi.DAL;
using DealerApi.DAL.Context;
using DealerApi.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace DealerApi.DAL.Extension
{
    public static class DataAccessLayerServiceExtension
    {
        public static IServiceCollection AddDataAccessLayerServices(this IServiceCollection services)
        {
            services.AddDbContext<DealerRndDBContext>(options =>
            options.UseSqlServer(services.BuildServiceProvider()
                .GetRequiredService<IConfiguration>()
                .GetConnectionString("DealerRndDBConnectionString")));

            // Register your data access layer services here
            services.AddScoped<ICustomer, CustomerDAL>();
            services.AddScoped<ICar, CarDAL>();
            services.AddScoped<IDealer, DealerDAL>();
            // Add other services as needed

            return services;
        }
        
    }
}