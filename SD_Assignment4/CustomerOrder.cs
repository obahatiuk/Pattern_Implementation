using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class CustomerOrder : Order, IObserver
    {
        static Farm farm = Farm.Instance();
        private BusinessUnit sentTo;
        private CustomerPayment customerPayment;
        public new BusinessUnit SentTo { get => sentTo = Farm.Instance(); }
        internal CustomerPayment CustomerPayment { get => customerPayment; set => customerPayment = value; }

        public CustomerOrder(int orderId, string date, BusinessUnit sentFrom, BusinessUnit sentTo, List<Item> goods, float total, bool isPaid, bool isShipped, CustomerPayment customerPayment)
: base(orderId, date, sentFrom, sentTo, goods,
             total, isPaid, isShipped)
        {
            this.sentTo = farm;
            this.customerPayment = customerPayment;
        }

        public CustomerOrder() { }

        public void Update()
        {
            IsPaid = customerPayment.IsPaid;
            Console.WriteLine("Observer {0}'s new state is {1}", OrderId, IsPaid);
        }
    }
}
