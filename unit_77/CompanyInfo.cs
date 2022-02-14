using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public abstract class CompanyInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Название: {Name}\nMail: {Email}\nАдрес: {Address}\nТелефон: {Phone}";
        }
    }
}
