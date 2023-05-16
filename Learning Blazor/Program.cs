using Learning_Blazor.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace Learning_Blazor.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddHttpClient("randomNumberAPI", client =>
            {
                client.BaseAddress = new Uri(builder.Configuration["RandomNumberAPIURL"]);
            });

            await builder.Build().RunAsync();
        }
    }
}
