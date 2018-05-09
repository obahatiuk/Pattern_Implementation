using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Poult : Item
    {
        private new string name;

        public new string Name { get => name = "Poult"; }

        public Poult(float price, float amount, string name = "Poult") : base(name, price, amount)
        {
           
        }

        public Poult() { }
    }
}
