using System;
using GrandLarceny.Data;
using SampSharp.Entities;

namespace GrandLarceny.Components
{
    /// <summary>
    /// Represents a component which provides data for a player which is the city selection screen.
    /// </summary>
    public class CitySelectionComponent : Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CitySelectionComponent" /> class.
        /// </summary>
        public CitySelectionComponent()
        {
            LastSelection = DateTime.UtcNow;
            SelectedCity = City.None;
        }

        /// <summary>
        /// Gets or sets the timestamp of the last city selection change.
        /// </summary>
        public DateTime LastSelection { get; set; }

        /// <summary>
        /// Gets or sets the currently selected city.
        /// </summary>
        public City SelectedCity { get; set; }
    }
}