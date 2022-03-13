using GrandLarceny.Repositories;
using GrandLarceny.Services;
using Microsoft.Extensions.DependencyInjection;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace GrandLarceny
{
    /// <summary>
    /// Represents a class which provides the configuration for the ECS game mode.
    /// </summary>
    public class Startup : IStartup
    {
        public void Configure(IServiceCollection services)
        {
            // Services can be added to the service collection which can later be accessed by systems and other services.
            services
                .AddTransient<ISpawnLocationRepository, SpawnLocationRepository>()
                .AddTransient<IScriptFilesService, ScriptFilesService>()
                .AddTransient<IVehicleSpawnParserService, VehicleSpawnParserService>()
                .AddSystemsInAssembly(); //Add all systems which can be found within the GrandLarceny project.
        }

        public void Configure(IEcsBuilder builder)
        {
            // Enable or disable features of ECS or other libraries here.
            builder.EnableSampEvents() // Enable all stock SA-MP callbacks as events which can be listened to by systems.
                .EnablePlayerCommands(); // Enable player commands being loaded in systems.
        }
    }
}