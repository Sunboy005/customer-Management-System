using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    class OrderRepository
    {
        //Retrieve one Order
        public Order Retrieve(int OrderId)
        {
            //To retrieve a Order from ID
            Order order = new Order();
            if (order.OrderId == 1)
            {
                order.OrderDate = new DateTimeOffset(2016, 3, 29, 12, 20, 35, 93, TimeSpan.FromHours(-3));
            }
            return order;
        }

        //Retrieve All Orders
        

        //Save Orders
        public bool Save()
        {
            //To save the defined Order
            return true;
        }

    }
}
