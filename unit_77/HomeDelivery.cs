using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    //Доставка на дом
    public class HomeDelivery : Delivery
    {
        public Courier Courier { set; get; }

        public override void ShowDeliveryInfo()
        {
            base.ShowDeliveryInfo();
            Console.WriteLine($"Курьерская компания: {Courier?.Company?.Name}");
            Console.WriteLine($"Курьер: {Courier?.Name}");
        }
    }
}
