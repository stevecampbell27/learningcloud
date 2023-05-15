using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Learning_Blazor.Client
{
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<HttpClient>(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001") });
    }

    public void Configure(IApplicationBuilder app)
    {
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapFallbackToFile("index.html");
        });
    }
}

}
