using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Ticket represents the personal boarding pass that each passenger must have.
    /// </summary>
    class Ticket
    {
        /// <summary>
        /// Represents the price due for this ticket.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Represents the boarding fee for this ticket.
        /// </summary>
        public decimal BoardingFee { get; set; }
        /// <summary>
        /// Represents the time the customer have done the check in.
        /// </summary>
        public DateTime CheckedIn { get; set; }
        /// <summary>
        /// Represents the quantity of luggage/bags the customer is carrying.
        /// </summary>
        public int Luggage { get; set; }
        /// <see cref="Flight">See Flight...</see>
        public Flight Flight { get; set; }
        /// <see cref="Passenger">See Passenger...</see>
        public Passenger Passenger { get; set; }
        /// <see cref="CancellationInsurance">See CancellationInsurance...</see>
        public CancellationInsurance Insurance { get; set; }
        /// <summary>
        /// Returns the seat reserved for this Ticket given the seat number.
        /// </summary>
        /// <param name="number">The number of the seat</param>
        /// <returns>Returns the seat object</returns>
        public Seat GetSeat(string number)
        {
            throw new NotImplementedException();
        }

    }
}
