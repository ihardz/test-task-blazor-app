﻿using BlazorApp.BusinessLogic.MappingProfiles;
using BlazorApp.BusinessLogic.Services;
using BlazorApp.BusinessLogic.Services.Abstraction;
using BlazorApp.DataAccess.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.BusinessLogic.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection services, string connectionString) 
        {
            return services
                .AddDataAccess(connectionString)
                .AddAutoMapper(typeof(OrderMappingProfile))
                .AddScoped<IOrderService, SalesOrderService>()
                .AddScoped<IStateService, StateService>();
        }
    }
}
