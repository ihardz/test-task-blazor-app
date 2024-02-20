using BlazorApp.Cache;
using BlazorApp.Cache.Abstraction;
using BlazorApp.Clients;
using BlazorApp.Clients.Abstraction;
using BlazorApp.MappingProfiles;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorApp
{
    public class Program
    {

        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddSingleton<ICacheManager, CacheManager>()
                .AddScoped(CreateHttpClient)
                .AddScoped<IStateClient, StateClient>()
                .AddScoped<ISubElementTypeClient, SubElementTypeClient>()
                .AddAutoMapper(typeof(DtoMappingProfile));;

            await builder.Build().RunAsync();
        }

        private static HttpClient CreateHttpClient(IServiceProvider serviceProvider)
        {
            var client = new HttpClient();
            var hostEnvironment = serviceProvider.GetRequiredService<IWebAssemblyHostEnvironment>();
            client.BaseAddress = new Uri(hostEnvironment.BaseAddress);
            return client;
        }
    }
}
