using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// This class holds data about a payment associated with an order.
    /// It stores amount, time, payment method the order and card used to make the payment
    /// </summary>
    class Payment
    {
        /// <summary>
        /// Total amount of the payment
        /// </summary>
        public double amount { get; set; }

        /// <summary>
        /// Date and Time of the payment
        /// </summary>
        public DateTime Timestamp { get; set; }
        
        /// <summary>
        /// Method of payment (Debit or Credit)
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// Order with which the payment is associated
        /// </summary>
        public Order Order { get; set; }

        /// <summary>
        /// <see cref="PaymentCard">Payment Card...</see>
        /// </summary>
        public PaymentCard Card { get; set; }

    }
}
