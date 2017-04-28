using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// This class represents a Pilot which inherits from Employee class(has common attibutes)
    /// </summary>
    class Pilot : Employee
    {
        /// <summary>
        /// The license number of the Pilot
        /// </summary>
        public string PilotLicense { get; set; }

        /// <summary>
        /// Total hours of Flight this Pilot has
        /// </summary>
        public int HoursOfFlight  { get; set; }
    }
}
