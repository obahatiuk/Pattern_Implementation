using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    class Goods
    {
        private int goodsId;
        private string name;
        private string expiryDate;
        

        public int GoodsId { get => goodsId; set => goodsId = value; }
        public string Name { get => name; set => name = value; }
        public string ExpiryDate { get => expiryDate; set => expiryDate = value; }

        public Goods(int goodsId, string name, string expiryDate)
        {
            this.goodsId = goodsId;
            this.name = name;
            this.expiryDate = expiryDate;
        }

        public Goods() { }

        public void OrderSupply(double amount, Supplier supplier)
        {
            Console.WriteLine(this.name + " is ordered. Amount of order is " + amount + ". Odrer date is " + DateTime.Now.ToShortDateString());
        }
    }
}
