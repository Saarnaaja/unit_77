using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public class PickPointCompany : CompanyInfo
    {
        public string WorkTime { set; get; }

        public override string ToString()
        {
            return $"{base.ToString()}\nРабочее время: {WorkTime}";
        }
    }
}
