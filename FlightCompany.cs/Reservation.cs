using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Reservation allows the user to hold a seat for some time (i.e. reserve seats to buy their Tickets later), as a typical flight reservation.
    /// </summary>
    class Reservation
    {
        /// <summary>
        /// When the Reservation was created.
        /// </summary>
        public DateTime Created { get; set; }
        /// <summary>
        /// When the Reservation expires. After expiration, the seat will become available and might be sold to someone else.
        /// </summary>
        public DateTime Expiration { get; set; }
        /// <see cref="Flight">See Flight...</see>
        public Flight Flight { get; set; }
        /// <see cref="Customer">See Customer...</see>
        public Customer Customer { get; set; }
        /// <see cref="Passengers">See Passenger...</see>
        public List<Passenger> Passengers { get; set; }
        /// <see cref="Attendant">See Attendant...</see>
        public Attendant Attendant { get; set; }

        /// <summary>
        /// Creates the Reservation to hold seats.
        /// </summary>
        /// <param name="flight">Which flight this reservation is related.</param>
        /// <param name="customer">The customer who owns the reservation.</param>
        /// <param name="passengers">The passengers who will have seats reserved for.</param>
        /// <returns>Returns a new Reservation instance.</returns>
        public Reservation CreateReservation(Flight flight, Customer customer, List<Passenger> passengers)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new passenger to be added to the reservation.
        /// </summary>
        /// <see cref="Passenger">See Passenger, which details all the input params.</see>
        /// <returns>Returns a new Passenger instance.</returns> 
        public Passenger CreatePassenger(string id, string firstName, string lastName, string passport, string address, DateTime birthdate, 
            string phone)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Persist and save all objects created and updated by this reservation.
        /// </summary>
        public void FinishReservation()
        {
            
        }
    }
}
