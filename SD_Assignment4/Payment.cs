using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class Payment 
    {
        private int paymentId;
        private Order order;
        private bool isPaid;
        private List<IObserver> observers = new List<IObserver>();

        public int PaymentId { get => paymentId; set => paymentId = value; }
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        internal Order Order { get => order; set => order = value; }

        public Payment(int paymentId, Order order, bool isPaid)
        {
            this.paymentId = paymentId;
            this.order = order;
            this.isPaid = isPaid;
        }

        public Payment() { }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
