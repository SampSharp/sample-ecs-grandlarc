using GrandLarceny.Data;

namespace GrandLarceny.Repositories
{
    /// <summary>
    /// Provides functionality for getting a random spawn location for a player.
    /// </summary>
    public interface ISpawnLocationRepository
    {
        /// <summary>
        /// Returns a random spawn location for a player in the specified <paramref name="city" />
        /// </summary>
        /// <param name="city">The city in which to get a spawn location.</param>
        /// <returns>The randomly chosen spawn location.</returns>
        PlayerSpawn GetRandomSpawnLocation(City city);
    }
}