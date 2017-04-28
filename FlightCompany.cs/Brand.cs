using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Brand represents the several brands which belongs to the same airline company, under its major name.
    /// </summary>
    class Brand
    {
        /// <summary>
        /// Represents the name of the brand.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents the physical address of the brand.
        /// </summary>
        public string Address { get; set; }
        /// <see cref="Airline">See Airline...</see>
        public Airline Airline { get; set; }
    }
}
