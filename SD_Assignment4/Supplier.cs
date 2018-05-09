using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Supplier : BusinessUnit
    {
        private string typeOfSupplier;

        public string TypeOfSupplier { get => typeOfSupplier; set => typeOfSupplier = value; }

        public Supplier(int unitId, string name, string address, string typeOfSupplier): base( unitId,  name,  address)
        {
            this.typeOfSupplier = typeOfSupplier;
        }

        public Supplier() { }

        public void placeOrder() { }
    }
}
