using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery { set; get; }
        public int Number { get; }
        public string Description { set; get; }
        public List<Product> Products { set; get; }

        public Order()
        {
            Description = string.Empty;
            Products = new List<Product>();
            OrderCounter.AddOrder(this);
            Number = OrderCounter.TotalOrdersCount;
            Delivery = default;
        }

        public void ShowOrderInfo()
        {
            Console.WriteLine($"Информация по заказу: {Number}");
            Console.WriteLine($"Описание: {Description}");
            Console.WriteLine($"Количество товаров: {Products.Count}");
            if (Delivery != null) Delivery.ShowDeliveryInfo();
        }
    }
}
