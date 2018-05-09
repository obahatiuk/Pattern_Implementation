using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class OfficeSubSystem
    {
        private SupplyOrder supplyOrder;
        private CustomerOrder customerOrder;
        private CustomerOrderBuillder customerOrderBuillder;

        public SupplyOrder SupplyOrder { get => supplyOrder; set => supplyOrder = value; }
        public CustomerOrder CustomerOrder { get => customerOrder; set => customerOrder = value; }
        public CustomerOrderBuillder CustomerOrderBuillder { get => customerOrderBuillder; set => customerOrderBuillder = value; }

        public SupplyOrder CreateSupplyOrder()
        {
            SupplyOrder supplyOrder = new SupplyOrder();
            return supplyOrder;
        }

        public CustomerOrder CreateCustomerOrder()
        {
            CustomerOrder customerOrder = new CustomerOrder();
            return customerOrder;
        }

        public CustomerOrderBuillder CreateCustomerOrderBuillder()
        {
            CustomerOrderBuillder customerOrderBuillder = new CustomerOrderBuillder();
            return customerOrderBuillder;
        }
    }
}
