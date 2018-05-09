using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class Item
    {
        private string name;
        private float price; 
        private float amount;

        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public float Amount { get => amount; set => amount = value; }

        public Item(string name, float price, float amount)
        {
            this.name = name;
            this.price = price;
            this.amount = amount;
        }

        public Item() { }
    }
}
