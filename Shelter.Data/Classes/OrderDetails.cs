using System;
namespace Shelter.Data.Classes
{
    public class OrderDetails
    {
        public int ID { get; set; }
        public Order ord_id;
        public Customer cust;
        public Inventory inv;
        public Locations location;

    }
}
