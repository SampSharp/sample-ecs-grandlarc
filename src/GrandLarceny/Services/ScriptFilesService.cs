using System.IO;
using SampSharp.Core;

namespace GrandLarceny.Services
{
    /// <inheritdoc />
    public class ScriptFilesService : IScriptFilesService
    {
        private readonly IGameModeClient _gameModeClient;

        public ScriptFilesService(IGameModeClient gameModeClient)
        {
            _gameModeClient = gameModeClient;
        }

        /// <inheritdoc />
        public Stream OpenFile(string fileName)
        {
            var serverPath = Directory.GetCurrentDirectory(); // TODO: use _gameModeClient.ServerPath instead

            var path = Path.Combine(serverPath, "scriptfiles", fileName);

            if (!File.Exists(path))
                throw new FileNotFoundException("The scriptfile could not be found.", path);

            return File.OpenRead(path);
        }
    }
}