using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Supplies
    {
        private Goods goods;
        private string date;
        private decimal quantity;

        public string Date { get => date; set => date = value; }
        public decimal Quantity { get => quantity; set => quantity = value; }
        internal Goods Goods { get => goods; set => goods = value; }

        public Supplies(Goods goods, string date, decimal quantity)
        {
            this.goods = goods;
            this.date = date;
            this.quantity = quantity;
        }

        public Supplies() { }

    }
}
