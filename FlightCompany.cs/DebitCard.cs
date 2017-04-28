using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Represents the customer Debit Card for making payments.
    /// </summary>
    class DebitCard : PaymentCard
    {
        /// <summary>
        /// Represents the bank of the card.
        /// </summary>
        public string Bank { get; set; }
        /// <see cref="PaymentCard">See PaymentCard...</see>
        public override void StartTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
