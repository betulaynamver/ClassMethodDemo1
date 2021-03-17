using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo_
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + "added to the database on " + customer.RegistrationDate);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer named " + customer.Name + " " + " deleted from database. ");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("Customer named " + customer.Name + " listed with " + customer.Gender + " genders.");
        }
    }
}
