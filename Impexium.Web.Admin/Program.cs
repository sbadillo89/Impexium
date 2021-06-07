using Impexium.Web.Admin.Repository;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace Impexium.Web.Admin
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            string ApiBaseUrl = ConfigurationManager.AppSettings["ApiUrl"];

            builder.Services.AddScoped(sp => new HttpClient()
            {
                BaseAddress = new Uri(ApiBaseUrl)
            });

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IAuthRepository, AuthRepository>();
            builder.Services.AddScoped<IProductRepository, ProductRepository>();

            await builder.Build().RunAsync();
        }
    }
}
