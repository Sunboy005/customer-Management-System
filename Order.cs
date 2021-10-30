using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }

        //Methods
        //Retrieve one Order
        public Order Retrieve(int OrderId)
        {
            //To retrieve a Order from ID
            return new Order();
        }

        //Retrieve All Orders
        public List<Order> Retrieve()
        {
            //To retrieve a Orders from ID
            return new List<Order>();
        }

        //Save Orders
        public bool Save()
        {
            //To save the defined Order
            return true;
        }

        //Validate the Data;
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
    }
}
