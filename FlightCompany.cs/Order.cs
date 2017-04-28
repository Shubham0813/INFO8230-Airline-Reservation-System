using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Order represents the customer buying one ore more tickets, and providing payments, as well.
    /// </summary>
    class Order
    {
        /// <summary>
        /// When the order was created.
        /// </summary>
        public DateTime Timestamp { get; set; }
        /// <summary>
        /// Which was the attendant who made the order. May be null if the customer ordered online.
        /// </summary>
        public Attendant Attendant { get; set; }
        /// <summary>
        /// The customer who is paying for this order.
        /// </summary>
        public Customer Customer { get; set; }
        /// <summary>
        /// The tickets payed by this order.
        /// </summary>
        public List<Ticket> Tickets { get; set; }
        /// <summary>
        /// All payments made for this order.
        /// </summary>
        public List<Payment> Payments { get; set; }


        /// <summary>
        /// Creates the order object.
        /// </summary>
        /// <param name="attendant">Attendant who made the order.</param>
        /// <param name="customer">The customer who is paying for this order.</param>
        /// <returns>A new order instance.</returns>
        public Order CreateOrder(Attendant attendant, Customer customer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Create a ticket attached to this order.
        /// </summary>
        /// <param name="price">Price of the ticket.</param>
        /// <param name="boardingFee">Boarding fee for the ticket.</param>
        /// <param name="luggage">How many luggage/bags for the ticket.</param>
        /// <returns>A new ticket instance.</returns>
        public Ticket CreateTicket(decimal price, decimal boardingFee, int luggage)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Call for AddPayment and AddInsurance before saving all objects and associations.
        /// </summary>
        public void FinishReservation()
        {
            AddPayment();
            AddInsurance();
        }

        private void AddPayment()
        {
            
        }

        private void AddInsurance()
        {
            
        }
    }
}
