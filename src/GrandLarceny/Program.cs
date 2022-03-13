using SampSharp.Core;
using SampSharp.Entities;

namespace GrandLarceny
{
    public class Program
    {
        private static void Main()
        {
            // This is the main entry-point of this application.
            // Start SampSharp with the ECS configuration provided by th Startup class.
            new GameModeBuilder()
                .UseEcs<Startup>()
                .Run();
        }
    }
}