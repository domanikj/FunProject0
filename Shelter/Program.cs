using System;
using System.Collections.Generic;
using System.Linq;
using Shelter.Data.Repo;
using Shelter.Data.Handler;
using Shelter.Data.Classes;

namespace Shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            //List to hold customers
            List<Customer> cust = new List<Customer>();
          
            // Instance or Repo
            Repo _repo = new Repo();

            // Start of program
            while (true)
            {
             // Label for goto 
            Menu:
                // Calling function from Repo class
                _repo.AdoptMenu();
                // String to keep track of answers
                string ans = Console.ReadLine();

                //Clear screen after user input
                Console.Clear();

                switch (int.Parse(ans))
                {
                    case 1:
                CustomerMenu:
                        // Calling customer menu
                        _repo.AdoptCustMenu();
                        try
                        {
                            // Holds users pick for customer session
                            string pic1 = Console.ReadLine();

                           // Decision for choice of user
                            if (int.Parse(pic1) == 1)
                            {
                                // Inst new Customer Object
                                var cus = new Customer();
                                // Calling function to add to cust list
                                _repo.AddCustomer(cus, cust);

                              
                              

                                







                            }
                            else if (int.Parse(pic1) == 2)
                            {
                                goto Menu;
                            }
                        }catch(Exception ex)
                        {
                            Console.WriteLine("Numbers Only! Try again\n");
                            goto CustomerMenu;
                        }
                        break;
                    case 2:
                AdminMenu:
                        _repo.AdoptAdminMenu();
                        try
                        {
                            string pic2 = Console.ReadLine();

                            if (int.Parse(pic2) == 1)
                            {
                                Console.WriteLine("PICK1Admin");
                            }
                            else if (int.Parse(pic2) == 2)
                            {
                                goto Menu;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Numbers Only! Try again\n");
                            goto AdminMenu;
                        }
                        break;

                    default:
                        Console.WriteLine("Incorrect input please try again");
                        break;
                }
            }
                

            }
           

        

        }
    }

