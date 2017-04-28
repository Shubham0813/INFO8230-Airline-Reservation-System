using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class Passenger
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string PassportNumber { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
    }
}
