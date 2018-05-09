using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD_Assignment4
{
    public class SupplyOrder : Order
    {
        static Farm farm = Farm.Instance();
        private BusinessUnit sentFrom = farm;
        private BusinessUnit sentTo;
        private int orderId;
        private string date;
        private List<Item> goods;
        private float total;
        private bool isPaid;
        private bool isShipped;

        public new BusinessUnit SentFrom { get => sentFrom = farm; }

        public SupplyOrder(int orderId, string date, BusinessUnit sentFrom, BusinessUnit sentTo, List<Item> goods, float total, bool isPaid, bool isShipped)
        : base(orderId, date, sentFrom, sentTo, goods,
             total, isPaid, isShipped)
        {
            this.sentFrom = farm;
        }

        public SupplyOrder() { }

        public new SupplyOrder Clone()
        {
            SupplyOrder order = new SupplyOrder();
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
