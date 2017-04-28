using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Represents the physical airport.
    /// </summary>
    class Airport
    {
        /// <summary>
        /// Represents the name of the physical airport.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents the global short code of the airport.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Represents the physical address of the airport.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Represents the physical gates of the airport.
        /// </summary>
        public List<Gate> Gates { get; set; }
    }
}
