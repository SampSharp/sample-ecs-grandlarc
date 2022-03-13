using System.Collections.Generic;
using System.IO;
using GrandLarceny.Data;

namespace GrandLarceny.Services
{
    /// <summary>
    /// Provides functionality for parsing a vehicle spawn positions file.
    /// </summary>
    public interface IVehicleSpawnParserService
    {
        /// <summary>
        /// Parses a vehicle spawn positions file from the specified <paramref name="stream" />.
        /// </summary>
        /// <param name="stream">The stream which contains the file to parse.</param>
        /// <returns>The vehicle spawn positions provided in the stream.</returns>
        IEnumerable<VehicleSpawn> Parse(Stream stream);
    }
}