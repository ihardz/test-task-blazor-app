using BlazorApp.DataAccess.DatabaseContexts;
using BlazorApp.DataAccess.Repositories;
using BlazorApp.DataAccess.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorApp.DataAccess.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection services, string connectionString)
        {
            return services
                .AddDbContextFactory<SalesDbContext>(options => options.UseSqlServer(connectionString))
                .AddScoped<IOrderRepository, SalesOrderRepository>();
        }
    }
}
