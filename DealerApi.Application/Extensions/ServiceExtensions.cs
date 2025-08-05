using System;
using DealerApi.Application.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DealerApi.Application.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Register your application services here
        services.AddScoped<ICarServices, CarServices>();
        // Add other services as needed

        return services;
    }

}
