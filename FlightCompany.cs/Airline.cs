using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Airline represents the company that uses the system, and is unique in the whole system.
    /// Therefore, its only instance is encapsulated inside of a Singleton.
    /// </summary>
    class Airline
    {
        private static Airline _instance;
        /// <summary>
        /// Represents the major name of the company.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Represents the physical address of the company.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Constructor is protected, in order to force the Singleton Pattern.
        /// </summary>
        protected Airline()
        {

        }
        /// <summary>
        /// Returns the only instance of Airline that exists in the whole system.
        /// </summary>
        public static Airline Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Airline();
                }
                return _instance;
            }
        }
    }
}
