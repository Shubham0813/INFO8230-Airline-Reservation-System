using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class DebitCard : PaymentCard
    {
        public string Bank { get; set; }

        public override void StartTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
