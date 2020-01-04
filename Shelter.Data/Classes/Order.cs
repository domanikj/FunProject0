using System;
using System.Collections.Generic;

namespace Shelter.Data.Classes
{
    public class Order
    {
        public int ID { get; set; }

        public Customer cust { get; set; }

        public DateTime dt { get; set; }

        public List<Inventory> inv = new List<Inventory>();

        public int Total { get; set; }

    }
}
