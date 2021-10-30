using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    public class ProductRepository
    {
        //Methods
        //Retrieve one Product
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);
            //To retrieve a customer from ID
            if (product.ProductId == 1)
            {
                product.ProductName = "Adrea Reality Guage";
                product.Description = "The only thing that makes the world revolve";
                product.CurrentPrice = 34;
            }
            return product;
        }
    }
}
