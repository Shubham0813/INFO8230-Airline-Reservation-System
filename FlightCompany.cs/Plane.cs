using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Plane represents the aircraft which is part of the company's fleet.
    /// </summary>
    class Plane
    {
        /// <summary>
        /// Represents a specific name for the aircraft.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents the model of the aircraft.
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Represents the date of fabrication of the aircraft.
        /// </summary>
        public DateTime Fabrication { get; set; }
        /// <see cref="Manufacturer">See Manufacturer...</see>
        public Manufacturer Manufacturer { get; set; }
        /// <see cref="Layout">See Layout...</see>
        public Layout Layout { get; set; }
    }
}
