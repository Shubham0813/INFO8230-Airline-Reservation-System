using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Employee class extends the User class and represent an employee of the Airline, 
    /// having a unique SinNumber
    /// </summary>
    class Employee : User
    {
        /// <summary>
        /// Social insurance number of the employee 
        /// </summary>
        public string SinNumber { get; set; }
    }
}
