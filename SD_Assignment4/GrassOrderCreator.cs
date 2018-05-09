using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class GrassOrderCreator
    {
        public SupplyOrder FactoryMethod(int month)
        {
            if (month < 6)
            {
                SupplyOrder s = new SupplyOrderSupplierA();
                return s;
            }
            else
            {
                SupplyOrder s = new SupplyOrderSupplierB();
                return s;
            }
        }
    }
}
