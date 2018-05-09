using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class CustomerOrderBuillder
    {
        ProductBuilder productBuilder = new ProductBuilder();
        public void ExecuteOrder(CustomerOrder customerOrder)
        {
            foreach (Item item in customerOrder.Goods)
            {
                if (item.Name == "Pork")
                {
                    productBuilder.MakePork();
                }
                else if (item.Name == "Poult")
                {
                    productBuilder.MakePoult();
                }
                else
                {
                    productBuilder.MakeBeef();
                }
            }
            customerOrder.IsShipped = true;
        }
    }
}
