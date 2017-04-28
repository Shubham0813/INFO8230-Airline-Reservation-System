using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Seat represents a specific seat for only one passenger inside the aircraft.
    /// </summary>
    class Seat
    {
        /// <summary>
        /// Represents the number of the seat.
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// Represents the physical position/place of the seat inside the aircraft.
        /// </summary>
        public int Place { get; set; }
        /// <see cref="Layout">See Layout...</see>
        public Layout Layout { get; set; }
        /// <see cref="SeatType">See SeatType...</see>
        public SeatType SeatType { get; set; }
    }
}
