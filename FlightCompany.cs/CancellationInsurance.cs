using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Represents the insurance that allows the customer to cancel their ticket.
    /// </summary>
    class CancellationInsurance
    {
        /// <summary>
        /// Represents the price of the insurance.
        /// </summary>
        public decimal Price { get; set; }
        /// <see cref="Ticket">See Ticket...</see>
        public Ticket Ticket { get; set; }
    }
}
