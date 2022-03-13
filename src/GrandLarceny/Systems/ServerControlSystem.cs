using System;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace GrandLarceny.Systems
{
    /// <summary>
    /// Represents a system which provides some basic server configuration.
    /// </summary>
    public class ServerControlSystem : ISystem
    {
        [Event]
        public void OnGameModeInit(IServerService serverService, IWorldService worldService)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Running Grand Larceny - by the SA-MP team");
            Console.WriteLine("Converted to SampSharp");
            Console.WriteLine("---------------------------------------");

            // Configure global server settings
            serverService.SetGameModeText("Grand Larceny");
            serverService.ShowPlayerMarkers(PlayerMarkersMode.Global);
            serverService.ShowNameTags(true);
            serverService.SetNameTagDrawDistance(40.0f);
            serverService.EnableStuntBonus(false);
            serverService.DisableInteriorEnterExits();
            serverService.SetWorldTime(11);

            worldService.SetWeather(2);
        }
    }
}