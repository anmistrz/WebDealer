using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.DAL.Interfaces;
using DealerApi.DAL;
using DealerApi.DAL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary.DAL.Extension
{
    public static class DataAccessLayerServiceExtension
    {
        public static IServiceCollection AddDataAccessLayerServices(this IServiceCollection services)
        {
            // Register your data access layer services here
            services.AddScoped<ICustomer, CustomerDAL>();
            services.AddScoped<ICar, CarDAL>();
            // Add other services as needed

            return services;
        }
        
    }
}