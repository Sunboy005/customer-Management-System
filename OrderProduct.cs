using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    class OrderProduct
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public string ProductOrdered { get; set; }
        public int PurchasedPrice { get; set; }
    }
}
