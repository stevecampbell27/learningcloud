using Microsoft.AspNetCore.Components;
using Learning_Blazor.Data;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["BaseAddress"]) });

builder.RootComponents.Add<Learning_Blazor.App>("app");

builder.Services.AddSingleton<WeatherForecastService>();

await builder.Build().RunAsync();
