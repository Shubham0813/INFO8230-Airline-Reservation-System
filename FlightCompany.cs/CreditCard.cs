using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class CreditCard : PaymentCard
    {
        public string Flag { get; set; }

        public override void StartTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
