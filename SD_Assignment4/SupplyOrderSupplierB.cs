using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class SupplyOrderSupplierB : SupplyOrder
    {
        
        public static Supplier supplierB = new Supplier(2, "Grass Inc.", "", "Forage"); 

        public SupplyOrderSupplierB()
        {
            this.SentTo = supplierB;
        }
    }
}
