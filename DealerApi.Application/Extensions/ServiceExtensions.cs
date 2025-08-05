using DealerApi.DAL.Extension;
using DealerApi.Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DealerApi.Application.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register your application services here
        services.AddDataAccessLayerServices();

        services.AddScoped<ICarServices, CarServices>();
        services.AddScoped<IDealerService, DealerServices>();
        // Add other services as needed

        // Removed recursive call to AddApplicationServices()

        return services;
    }
}