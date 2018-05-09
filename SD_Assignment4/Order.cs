using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class Order 
    {
        private int orderId;
        private string date;
        private BusinessUnit sentFrom;
        private BusinessUnit sentTo;
        private List<Item> goods;
        private float total;
        private bool isPaid;
        private bool isShipped;

        public int OrderId { get => orderId; set => orderId = value; }
        public string Date { get => date; set => date = value; }
        public BusinessUnit SentFrom { get => sentFrom; set => sentFrom = value; }
        public BusinessUnit SentTo { get => sentTo; set => sentTo = value; }
        
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        public bool IsShipped { get => isShipped; set => isShipped = value; }
        internal List<Item> Goods { get => goods; set => goods = value; }
        public float Total { get => total; set => total = value; }

        public Order(int orderId, string date, BusinessUnit sentFrom, BusinessUnit sentTo, List<Item> goods, float total, bool isPaid, bool isShipped)
        {
            this.orderId = orderId;
            this.date = date;
            this.sentFrom = sentFrom;
            this.sentTo = sentTo;
            this.goods = goods;
            this.total = total;
            this.isPaid = isPaid;
            this.isShipped = isShipped;
        }

        public Order() { }

        public void addItemToOrder(string itemName, float itemPrice, float itemAmount)
        {
            Item item = new Item(itemName, itemPrice, itemAmount);
            goods.Add(item);
            total += item.Amount * item.Price;

        }

        public Order Clone()
        {
            Order order = new Order();
            order.orderId = this.orderId;
            order.date = this.date;
            order.sentFrom = this.sentFrom;
            order.sentTo = this.sentTo;
            order.goods = this.goods;
            order.total = this.total;
            order.isPaid = this.isPaid;
            order.isShipped = this.isShipped;
            return order;
        }
    }
}
