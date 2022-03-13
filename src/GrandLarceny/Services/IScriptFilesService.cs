using System.IO;

namespace GrandLarceny.Services
{
    /// <summary>
    /// Provides functionality for using files in the scriptfiles folder of the SA-MP server.
    /// </summary>
    public interface IScriptFilesService
    {
        /// <summary>
        /// Opens the file with the specified <paramref name="fileName" /> in the scriptfiles folder.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>A stream of the file.</returns>
        /// <exception cref="FileNotFoundException">Thrown if the scriptfile could not be found.</exception>
        Stream OpenFile(string fileName);
    }
}