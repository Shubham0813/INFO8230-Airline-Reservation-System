using System;

namespace FlightCompany.cs
{
    /// <summary>
    /// This class holds information about the common attributes between different types od cards. 
    /// </summary>
    abstract class PaymentCard
    {
        /// <summary>
        /// Name of the card holder
        /// </summary>
        public string CardHolder { get; set; }

        /// <summary>
        /// Expiration date of the card
        /// </summary>
        public DateTime Expiration { get; set; }

        /// <summary>
        /// Number of the card
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Abstract method that will start the process of transaction by communicating with the Bank.
        /// Different methods of payment will define their own process of making a transaction.
        /// </summary>
        public abstract void StartTransaction();
    }
}