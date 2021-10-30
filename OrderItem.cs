using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasedPrice { get; set; }
        public int Quantity { get; set; }
        
        //Methods
        //Retrieve one Order
        public OrderItem Retrieve(int OrderitemId)
        {
            //To retrieve a Order from ID
            return new OrderItem();
        }

        //Retrieve All Orders
        public List<OrderItem> Retrieve()
        {
            //To retrieve a customer from ID
            return new List<OrderItem>();
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
            if (Quantity<1) isValid = false;
            if (ProductId < 1) isValid = false;
            if (PurchasedPrice ==null) isValid = false;
            return isValid;
        }
    }
}
