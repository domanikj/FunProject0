using System;
using System.Collections.Generic;
using System.Linq;

namespace Shelter
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> names = new List<string>();
            names.Add("Domanik");
            names.Add("King");
            names.Add("Lavon");
            names.Add("Gerald");

            var result = names.Where(s => s.Contains("a"));
            var res = from name in names
                      where name.Contains("D")
                      select name;

            foreach(var nam in result)
            {
                Console.WriteLine(nam);
            }

        }
    }
}
