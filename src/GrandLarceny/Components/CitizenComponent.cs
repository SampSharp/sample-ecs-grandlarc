using GrandLarceny.Data;
using SampSharp.Entities;

namespace GrandLarceny.Components
{
    /// <summary>
    /// Represents a component which provides data for a player whom has chosen a spawn city.
    /// </summary>
    public class CitizenComponent : Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CitizenComponent" /> class.
        /// </summary>
        /// <param name="city">The spawn city.</param>
        public CitizenComponent(City city)
        {
            City = city;
        }

        /// <summary>
        /// Gets or sets the spawn city.
        /// </summary>
        public City City { get; set; }
    }
}