using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    //Доставка в магазин
    public class ShopDelivery : Delivery
    {
        public string ShopName { set; get; }

        public override void ShowDeliveryInfo()
        {
            base.ShowDeliveryInfo();
            Console.WriteLine($"Название магазина: {ShopName}");
        }
    }
}
 