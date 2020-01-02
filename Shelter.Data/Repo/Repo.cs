using System;
using Shelter.Data.Handler;

namespace Shelter.Data.Repo
{
    public class Repo : IRepo, IMenu
    {






        public  void AdoptMenu()
        {
         Console.WriteLine("Welcome to Adopt Me! Please, select a options\n[1]: Customer\n[2]: Admin");

        }

        public void AdoptCustMenu()
        {
         Console.WriteLine("Welcome to Customer Menu! Please, select options\n[1]: Sign in\n[2]: Back to menu");
        }

        public void AdoptAdminMenu()
        {

         Console.WriteLine("Welcome to Admin Menu! Please, select options\n[1]: Sign in\n[2]: Back to menu");
        }





    }
}
