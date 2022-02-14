using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public class CourierCompany : CompanyInfo
    {
        public CourierCollection Couriers { get; }

        public CourierCompany()
        {
            Couriers = new CourierCollection(this);
        }
    }
}
