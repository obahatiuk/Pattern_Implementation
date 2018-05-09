using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class CustomerPayment : Payment
    {
        public CustomerPayment(int paymentId, Order order, bool isPaid) : base(paymentId, order, isPaid)
        {
        }
    }
}
