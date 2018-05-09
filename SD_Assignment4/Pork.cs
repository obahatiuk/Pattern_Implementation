using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Pork : Item
    {
        private new string name;

        public new string Name { get => name = "Pork";  }

        public Pork(float price, float amount, string name = "Pork") : base( name, price, amount)
        {

        }

        public Pork() { }

    }
}
