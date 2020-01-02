using System;
namespace Shelter.Data.Classes
{
    public class OrderDetails
    {
        public int ID { get; set; }

        Order ord_id;
        Customer cust;
        Inventory inv;
        Locations location;

    }
}
