using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// Abstract User class that saves common information for different types of users.
    /// </summary>
    abstract class User
    {
        /// <summary>
        /// The unique username of the user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// First name of the user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the user
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Password of the user used to log in to account
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Address of the user
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Contact number of the user
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// PersonID of the User
        /// </summary>
        public string PersonID { get; set; }

   }
}

