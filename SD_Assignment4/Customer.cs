using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Customer
    {
        private int customerId;
        private string name;
        private string address;
        private string typeOfCustomer;
        
        public int CustomerId { get => customerId; set => customerId = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string TypeOfCustomer { get => typeOfCustomer; set => typeOfCustomer = value; }

        public Customer(int customerId, string name, string address, string typeOfCustomer)
        {
            this.customerId = customerId;
            this.name = name;
            this.address = address;
            this.typeOfCustomer = typeOfCustomer;
        }

        Customer() { }
    }
}
