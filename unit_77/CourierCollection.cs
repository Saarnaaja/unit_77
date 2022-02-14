using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public class CourierCollection : IEnumerable<Courier>
    {
        private List<Courier> _list;
        private CourierCompany _company;

        public int Count => _list.Count;

        public Courier this[int index]
        {
            get
            {
                if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException("index");
                return _list[index];
            }
            set
            {
                if (index < 0 || index >= Count) throw new ArgumentOutOfRangeException("index");
                _list[index] = value;
            }
        }

        internal CourierCollection(CourierCompany company)
        {
            _list = new List<Courier>();
            _company = company;
        }

        public void Add(Courier courier)
        {
            if (courier == null) return;
            _list.Add(courier);
            courier.Company = _company;
        }

        public bool Remove(Courier courier)
        {
            if (_list.Remove(courier))
            {
                courier.Company = null;
                return true;
            }
            return false;
        }

        public IEnumerator<Courier> GetEnumerator()
        {
            return ((IEnumerable<Courier>)_list).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_list).GetEnumerator();
        }
    }
}
