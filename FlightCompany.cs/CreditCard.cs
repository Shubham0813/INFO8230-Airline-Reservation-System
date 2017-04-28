using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Represents the customer Credit Card for making payments.
    /// </summary>
    class CreditCard : PaymentCard
    {
        /// <summary>
        /// Represents the financial company flag (i.e. VISA, MasterCard)
        /// </summary>
        public string Flag { get; set; }
        /// <see cref="PaymentCard">See PaymentCard...</see>
        public override void StartTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
