using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JYRAX.BL
{
    public class CustomerRepository
    {
        //Methods
        //Retrieve one Customer
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.FirstName="Akinola";
                customer.LastName = "Amos";
                customer.Email = "amos.alagbe@decagon.dev";
            }
            //To retrieve a customer from ID
            return customer;
        }

        //Retrieve All Customer
        public bool Save()
        {
            //To Save a customer details
            return true;
        }

    }
}
