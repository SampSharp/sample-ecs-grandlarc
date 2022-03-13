using SampSharp.Entities.SAMP;

namespace GrandLarceny.Data
{
    /// <summary>
    /// Represents a player spawn location.
    /// </summary>
    public struct PlayerSpawn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerSpawn" /> struct.
        /// </summary>
        /// <param name="position">The position of the spawn location.</param>
        /// <param name="angle">The angle of the spawn location.</param>
        public PlayerSpawn(Vector3 position, float angle)
        {
            Position = position;
            Angle = angle;
        }

        /// <summary>
        /// Gets the position of this spawn location.
        /// </summary>
        public Vector3 Position { get; }

        /// <summary>
        /// Gets the angle of this spawn location.
        /// </summary>
        public float Angle { get; }
    }
}