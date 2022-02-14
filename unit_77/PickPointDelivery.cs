using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    //Доставка в пункт выдачи
    public class PickPointDelivery : Delivery
    {
        private PickPointCompany _point;

        public override string Address 
        {
            get => PickPoint.Address;
        }

        public PickPointCompany PickPoint 
        { 
            set 
            {
                _point = value ?? throw new ArgumentNullException("value"); 
            }
            get => _point;
        }

        public PickPointDelivery(PickPointCompany point)
        {
            PickPoint = point;
        }

        public override void ShowDeliveryInfo()
        {
            base.ShowDeliveryInfo();
            Console.WriteLine($"Пункт выдачи: {PickPoint.Name}");
            Console.WriteLine($"Время работы: {PickPoint.WorkTime}");
        }
    }
}
