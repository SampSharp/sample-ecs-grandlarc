using SampSharp.Entities.SAMP;

namespace GrandLarceny.Data
{
    /// <summary>
    /// Represents a vehicle spawn location.
    /// </summary>
    public struct VehicleSpawn
    {
        /// <summary>
        /// Gets or sets the model of this vehicle spawn.
        /// </summary>
        public VehicleModelType Model { get; set; }

        /// <summary>
        /// Gets or sets the position of this vehicle spawn.
        /// </summary>
        public Vector3 Position { get; set; }

        /// <summary>
        /// Gets or sets the angle of this vehicle spawn.
        /// </summary>
        public float Angle { get; set; }

        /// <summary>
        /// Gets or sets the first color of this vehicle to spawn.
        /// </summary>
        public int Color1 { get; set; }

        /// <summary>
        /// Gets or sets the second color of this vehicle to spawn.
        /// </summary>
        public int Color2 { get; set; }
    }
}