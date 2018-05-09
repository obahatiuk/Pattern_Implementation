using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class CustomerOrderProducts
    {
        private List<Item> items = new List<Item>();

        public void addItem(Item item)
        {
            items.Add(item);
        }

        public float getCoast()
        {
            float cost = 0.0f;
            foreach (Item item in items)
            {
                cost += item.Price * item.Amount;
            }
            return cost;
        }

        public void showItem()
        {
            foreach (Item item in items)
            {
                Console.WriteLine("Item: " + item.Name
                    + ", Price: "+ item.Price + ", Ammount: "+ item.Amount);
            }
        }
    }
}
