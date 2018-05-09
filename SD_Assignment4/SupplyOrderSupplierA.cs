using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class SupplyOrderSupplierA : SupplyOrder
    {
        public static Supplier supplierA = new Supplier(1, "Grass Ink", "", "Forage");
        
        public SupplyOrderSupplierA()
        {
            this.SentTo = supplierA;
        }
    }
}
