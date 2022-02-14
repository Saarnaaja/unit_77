using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public class Courier
    {
        public string Name { get; set; }
        public CourierCompany Company { internal set; get; }

        public Courier(string name)
        {
            Name = name;
        }

        public Courier(string name, CourierCompany company) : this(name)
        {
            Company = company ?? throw new ArgumentNullException("company");
            Company.Couriers.Add(this);
        }
    }
}
