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
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                _productName = value;
            }
        }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }




        //Validate the Data;
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (string.IsNullOrEmpty(Description)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
