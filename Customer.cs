using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public string FirstName { get; set; }

        private string _lastName;
        public string LastName 
        {
            get
            {
                return _lastName;
            }
            set 
            {
                _lastName = value;
            }
        }
        public string Email { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get 
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += " ";
                    }
                    fullName += FirstName;
                }
                return fullName;                    
            }
        }
        public static int instanceCount { get; set; }


        //Methods
        //Retrieve one Customer
        public Customer Retrieve(int customerId)
        {
            //To retrieve a customer from ID
            return new Customer();
        }

        //Retrieve All Customer
        public List<Customer> Retrieve()
        {
            //To retrieve a customer from ID
            return new List<Customer>();
        }
        
        //Validate the Data;
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(Email)) isValid = false;
            return isValid;
        }
    }
}
