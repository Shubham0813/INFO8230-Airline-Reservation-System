using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class CustomerWithNoAccount
    {
        private List<PaymentCard> _paymentCards = new List<PaymentCard>();

        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PersonalID { get; set; }
        public string PassportNumber { get; set; }

        public void AddCard(PaymentCard card)
        {
            _paymentCards.Add(card);
        }

        public List<PaymentCard> GetCards()
        {
            return _paymentCards;
        }

    }
}
