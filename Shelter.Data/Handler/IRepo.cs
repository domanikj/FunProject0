using System;
using System.Collections.Generic;
using Shelter.Data.Classes;

namespace Shelter.Data.Handler
{
    public interface IRepo
    {
        Customer AddCustomer(Customer customer, List<Customer> cust);


    }
}
