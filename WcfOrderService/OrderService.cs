using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfOrderService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class OrderService : IOrderService
    {
        static private Order _order = new Order();
        public Order GetOrder()
        {
            return _order;
        }

        public Order UpdateOrder(int amount)
        {
            _order.Amount = amount;
            return _order;
        }
    }
}
