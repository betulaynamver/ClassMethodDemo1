using System;

namespace ClassMethodDemo_
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Betülay Namver";
            customer1.Gender = "Female";
            customer1.Age = 21;
            customer1.RegistrationDate = "15th March 2021";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Can Yüksel";
            customer2.Gender = "Male";
            customer2.Age = 28;
            customer2.RegistrationDate = "5th March 2019";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Mehmet Namver";
            customer3.Gender = "Male";
            customer3.Age = 22;
            customer3.RegistrationDate = "3th September 2020";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);
            customerManager.Delete(customer1);
            customerManager.List(customer2);
        }
    }
}
