using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public abstract class Delivery
    {
        public virtual string Address { set; get; }
        public DateTime Date { set; get; }
        public virtual void ShowDeliveryInfo()
        {
            Console.WriteLine($"Адрес доставки: {Address}");
            Console.WriteLine($"Дата доставки: {Date}");
        }
    }
}
