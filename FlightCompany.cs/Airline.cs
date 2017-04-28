using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class Airline
    {
        private static Airline _instance;

        public string Name { get; set; }
        public string Address { get; set; }

        protected Airline()
        {

        }

        public static Airline Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Airline();
                }
                return _instance;
            }
        }
    }
}
