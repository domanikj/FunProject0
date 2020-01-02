using System;
using System.Collections.Generic;
using System.Linq;
using Shelter.Data.Repo;
using Shelter.Data.Handler;
namespace Shelter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance or Repo
            IRepo _repo = new Repo();

            while (true)
            {
                _repo.AdoptMenu();
                string ans = Console.ReadLine();
                Console.Clear();

                switch (int.Parse(ans))
                {
                    case 1:
                        Console.WriteLine("Welcome to Customer Menu! Please, select options\n[1]: Sign in\n[2]: Back to menu");
                        string pic = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Admin Menu");
                        break;
                    default:
                        Console.WriteLine("Incorrect input please try again");
                        break;
                }
            }
                

            }
           

        

        }
    }

