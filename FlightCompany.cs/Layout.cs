using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Layout represents the position of passengers seats inside the aircraft.
    /// </summary>
    class Layout
    {
        /// <summary>
        /// Represents a name given to a specific layout.
        /// </summary>
        public string Name { get; set; }
        /// <see cref="Plane">See Plane...</see>
        public List<Plane> Planes { get; set; }
        /// <see cref="Seat">See Seat...</see>
        public List<Seat> Seats { get; set; }
    }
}
