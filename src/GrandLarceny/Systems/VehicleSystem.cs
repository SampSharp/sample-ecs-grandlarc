using System;
using GrandLarceny.Services;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace GrandLarceny.Systems
{
    /// <summary>
    /// Represents a system which spawns the vehicles in the world.
    /// </summary>
    public class VehicleSystem : ISystem
    {
        [Event]
        public void OnGameModeInit(IWorldService worldService, IScriptFilesService scriptFilesService, IVehicleSpawnParserService vehicleSpawnParser)
        {
            var totalVehiclesFromFiles = 0;

            // Loads the vehicles defined in a file in the scriptfiles of the SA-MP server directory.
            void LoadVehicles(string fileName)
            {
                // Open a file stream from the scriptfiles folder.
                using var stream = scriptFilesService.OpenFile(fileName);

                // Parse each line in the file and create a vehicle for it.
                foreach (var spawnPosition in vehicleSpawnParser.Parse(stream))
                {
                    worldService.CreateStaticVehicle(spawnPosition.Model, spawnPosition.Position, spawnPosition.Angle,
                        spawnPosition.Color1, spawnPosition.Color2);
                    totalVehiclesFromFiles++;
                }
            }

            // SPECIAL
            LoadVehicles("vehicles/trains.txt");
            LoadVehicles("vehicles/pilots.txt");

            // LAS VENTURAS
            LoadVehicles("vehicles/lv_law.txt");
            LoadVehicles("vehicles/lv_airport.txt");
            LoadVehicles("vehicles/lv_gen.txt");

            // SAN FIERRO
            LoadVehicles("vehicles/sf_law.txt");
            LoadVehicles("vehicles/sf_airport.txt");
            LoadVehicles("vehicles/sf_gen.txt");

            // LOS SANTOS
            LoadVehicles("vehicles/ls_law.txt");
            LoadVehicles("vehicles/ls_airport.txt");
            LoadVehicles("vehicles/ls_gen_inner.txt");
            LoadVehicles("vehicles/ls_gen_outer.txt");

            // OTHER AREAS
            LoadVehicles("vehicles/whetstone.txt");
            LoadVehicles("vehicles/bone.txt");
            LoadVehicles("vehicles/flint.txt");
            LoadVehicles("vehicles/tierra.txt");
            LoadVehicles("vehicles/red_county.txt");

            Console.WriteLine($"Total vehicles from files: {totalVehiclesFromFiles}");
        }
    }
}