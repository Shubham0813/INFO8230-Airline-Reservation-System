using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class Pilot : Employee
    {
        public string PilotLicense { get; set; }
        public int HoursOfFlight  { get; set; }
    }
}
