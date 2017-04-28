using System;

namespace FlightCompany.cs
{
    abstract class PaymentCard
    {
        public string CardHolder { get; set; }
        public DateTime Expiration { get; set; }
        public string Number { get; set; }

        public abstract void StartTransaction();
    }
}