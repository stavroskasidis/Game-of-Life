using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using GameOfLife.Engine.Contracts;
using GameOfLife.Engine.Implementations;

namespace GameOfLife.Blazor
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<ICellNeighbourResolver, CellNeighbourResolver>();
            builder.Services.AddSingleton<ICellStateCalculator, CellStateCalculator>();
            builder.Services.AddSingleton<IGenerationCloner, GenerationCloner>();
            builder.Services.AddSingleton<IGenerationIterator, GenerationIterator>();
            builder.Services.AddSingleton<IGenerationSetter, GenerationSetter>();


            await builder.Build().RunAsync();
        }
    }
}
