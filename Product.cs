using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public int ProductId { get; private set; }
        private string _productName;
        public string ProductName{ get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        
        //Methods
        //Retrieve one Product
        public Product Retrieve(int ProductId)
        {
            //To retrieve a customer from ID
            return new Product();
        }

        //Retrieve All Products
        public List<Product> Retrieve()
        {
            //To retrieve a customer from ID
            return new List<Product>();
        }

        //Validate the Data;
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (string.IsNullOrEmpty(Description)) isValid = false;
            if (CurrentPrice < 1) throw new ArgumentException("Price must be greater than 0");
            return isValid;
        }
    }
}
