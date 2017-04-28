using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// This class represents an Attendant which is a type of Employee but also has a land position
    /// </summary>
    class Attendant : Employee
    {
        /// <summary>
        /// The land position for attendant
        /// </summary>
        public string LandPosition { get; set; }
    }
}
