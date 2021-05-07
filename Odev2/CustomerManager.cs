using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.name +" "+customer.lastName +" has been added.");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.name +" "+ customer.lastName +"has been deleted.");
        }
         
    }
}
