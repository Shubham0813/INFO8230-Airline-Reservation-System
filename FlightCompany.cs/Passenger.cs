using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Passenger represents the customer travelling in the aircraft.
    /// </summary>
    class Passenger
    {
        /// <summary>
        /// The unique identification of the passenger. (i.e. Driver's License)
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// First name of the passenger.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the passenger.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Passport number of the passenger.
        /// </summary>
        public string PassportNumber { get; set; }
        /// <summary>
        /// Address of the passenger.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Birth date of the passenger.
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Phone number of the passenger.
        /// </summary>
        public string Phone { get; set; }
        /// <see cref="Reservation">See Reservation</see>
        public Reservation Reservation { get; set; }
        /// <see cref="Ticket">See Ticket</see>
        public Ticket Ticket { get; set; }
        /// <see cref="Seat">See Seat</see>
        public Seat Seat { get; set; }
    }
}
