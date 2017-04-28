using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// This class acts as a creator for different types of Employees (Pilot, Crew, Attendant) 
    /// </summary>
    class EmployeeCreator
    {
        /// <summary>
        /// This method creates and returns an instance of a specific type of Employee based on user input
        /// </summary>
        /// <param name="employeeData">Information about the employee including its type</param>
        /// <returns>Instance of a specific type of Employee (Pilot, Crew or Attendant)</returns>
        public Employee FactoryMethod(Dictionary<string,string> employeeData)
        {
            throw new NotImplementedException();
        }
    }
}
