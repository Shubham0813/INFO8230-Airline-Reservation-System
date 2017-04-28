using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class ObserverClasses
    {

        class FlightsWebService : FlightObserver
        {
            public void Update(Flight flight)
            {
                throw new NotImplementedException();
            }
        }

        class CheckInKiosk : FlightObserver
        {
            public void Update(Flight flight)
            {
                throw new NotImplementedException();
            }
        }

        class AirportPanels : FlightObserver
        {
            public void Update(Flight flight)
            {
                throw new NotImplementedException();
            }
        }

        class EmailMessages : FlightObserver
        {
            public void Update(Flight flight)
            {
                throw new NotImplementedException();
            }
        }

    }
}