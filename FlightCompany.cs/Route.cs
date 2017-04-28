using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Route holds the information about the distance, Gate from where the flight will leave
    /// and the Gate where it will arrive.
    /// <see cref="Gate">See Gate...</see>
    /// </summary>
    class Route
    {
        /// <summary>
        /// The distance of the Route from origin to destination
        /// </summary>
        public int DistanceKM { get; set; }

        /// <summary>
        /// This represents the Gate from where the flight will be leaving
        /// <see cref="Gate">See Gate..</see>
        /// </summary>
        public Gate Origin { get; set; }

        /// <summary>
        /// This represents the Gate where the Flight will be arriving
        /// <see cref="Gate">See Gate...</see>
        /// </summary>
        public Gate Destination { get; set; }
    }
}
