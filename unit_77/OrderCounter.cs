using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_77
{
    public static class OrderCounter
    {
        private static Dictionary<Type, List<object>> _orderCollection;

        /// <summary>
        /// Количество всех заказов.
        /// </summary>
        public static int TotalOrdersCount
        {
            get
            {
                var sum = 0;
                foreach (var order in _orderCollection)
                    sum+= order.Value.Count;
                return sum;
            }
        }

        static OrderCounter()
        {
            _orderCollection = new Dictionary<Type, List<object>>();
        }

        internal static void AddOrder<TDelivery>(Order<TDelivery> order) where TDelivery : Delivery
        {
            if (_orderCollection.ContainsKey(typeof(TDelivery)))
            {
                _orderCollection[typeof(TDelivery)].Add(order);
            }
            else
            {
                _orderCollection.Add(typeof(TDelivery), new List<object> { order });
            }
        }

        /// <summary>
        /// Информация о всех заказах с определенным типом доставки.
        /// </summary>
        /// <typeparam name="TDelivery">Тип доставки.</typeparam>
        /// <returns></returns>
        public static List<Order<TDelivery>> GetOrders<TDelivery>() where TDelivery : Delivery
        {
            if (_orderCollection.ContainsKey(typeof(TDelivery)))
            {
                var list = new List<Order<TDelivery>>();
                foreach (var o in _orderCollection[typeof(TDelivery)]) 
                    list.Add(o as Order<TDelivery>);
                return list;
            }
            return null;
        }
    }
}
