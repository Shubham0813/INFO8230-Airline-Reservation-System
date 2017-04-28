using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    /// <summary>
    /// This class represents customers who will purchase a ticket without creating an account
    /// </summary>
    class CustomerWithNoAccount
    {
        //private List<PaymentCard> _paymentCards = new List<PaymentCard>();

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

        /// <summary>
        /// Passport number of the customer
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// <see cref="PaymentCard">PaymentCard...</see>
        /// </summary>
        public PaymentCard PaymentCard { get; set; }

//        public void AddCard(PaymentCard card)
//        {
//            _paymentCards.Add(card);
//        }
//
//        public List<PaymentCard> GetCards()
//        {
//            return _paymentCards;
//        }

    }
}
