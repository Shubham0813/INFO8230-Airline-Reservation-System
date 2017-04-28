using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// This class represents a crew member for a Flight
    /// </summary>
    class Crew : Employee
    {
        /// <summary>
        /// The position in the plane where the crew member will be working
        /// </summary>
        public string PlanePosition { get; set; }
    }
}
