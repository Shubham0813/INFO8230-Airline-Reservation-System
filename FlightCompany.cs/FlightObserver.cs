using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// This interface is implemented by classes interested in observing a flight (an instance of Flight Class).
    /// Classes implementing this interface will their own implementation of Update method taking an instance of Flight class as parameter
    /// </summary>
    interface FlightObserver

    {
        /// <summary>
        /// Implementation for this method will be provided by classes implementing this interface.
        /// It will define the appropriate instructions to be performed when any change to flight it was observing take place.
        /// </summary>
        /// <param name="flight">Flight</param>
        void Update(Flight flight);
    }
}
