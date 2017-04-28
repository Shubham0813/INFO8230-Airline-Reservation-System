using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class Payment
    {
        public double Value { get; set; }
        public DateTime Timestamp { get; set; }
        public string MethodName { get; set; }

        public Order Order { get; set; }
        public PaymentCard Card { get; set; }

    }
}
