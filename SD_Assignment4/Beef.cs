using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Beef : Item
    {
        private new string name;

        public new string Name { get => name = "Beef"; }

        public Beef(float price, float amount, string name = "Beef") : base(name, price, amount)
        {

        }

        public Beef() { }
    }
}
