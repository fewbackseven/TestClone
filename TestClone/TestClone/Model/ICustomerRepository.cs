using System;
using System.Collections.Generic;
using System.Text;

namespace TestClone.Model
{
    public interface ICustomerRepository
    {
        CustomerDataClass GetCustomer(int Id);


        List<CustomerDataClass> GetListofCustomers();
    }
}
