using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightCompany.cs
{
    class Customer : User
    {
        private List<PaymentCard> _cards = new List<PaymentCard>();

        public string PassportNumber { get; set; }

//        public override User CreateAccount()
//        {
//            throw new NotImplementedException();
//        }

        public void AddCard(PaymentCard card)
        {
            _cards.Add(card);
        }

        public List<PaymentCard> GetCards()
        {
            return _cards;
        }
    }
}
