using System;
using System.Collections.Generic;
using Shelter.Data.Classes;
using Shelter.Data.Handler;
using Serilog;

namespace Shelter.Data.Repo
{
    public class Repo : IRepo, IMenu
    {
        public Customer AddCustomer(Customer customer, List<Customer> cust)
        {

            Log.Information("In function");
            Console.WriteLine("Enter your first name?");
            customer.Firstname = Console.ReadLine();
            Console.WriteLine("Enter your last name?");
            customer.Lastname = Console.ReadLine();
            Console.WriteLine("Enter your Email?");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Enter your Password?");
            customer.Password = Console.ReadLine();

            cust.Add(customer);
            return customer;

        }
        







        public  void AdoptMenu()
        {
         Console.WriteLine("Welcome to Adopt Me! Please, select a options\n[1]: Customer\n[2]: Admin");

        }

        public void AdoptCustMenu()
        {
         Console.WriteLine("Welcome to Customer Menu! Please, select options\n[1]: Register\n[2]: Sign in\n[3]: Back to menu");
        }

        public void AdoptAdminMenu()
        {

         Console.WriteLine("Welcome to Admin Menu! Please, select options\n[1]: Sign in\n[2]: Back to menu");
        }

       
    }
}
