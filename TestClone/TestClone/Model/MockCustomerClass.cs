using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestClone.Model
{
    public class MockCustomerClass:ICustomerRepository
    {
        private List<CustomerDataClass> _customersList;

        public MockCustomerClass()
        {
            _customersList = new List<CustomerDataClass>()
            {
                new CustomerDataClass(){Id=1, CustomerName="Shraddha", AmntToGive=500,AmntToRecieve=0, dateTime=new DateTime(2021,08,21,09,15,0)},
                new CustomerDataClass(){Id=2, CustomerName="Lavanya", AmntToGive=400,AmntToRecieve=0, dateTime=new DateTime(2021,08,23,09,15,0)},
                new CustomerDataClass(){Id=3, CustomerName="Deepika", AmntToGive=0,AmntToRecieve=500, dateTime=new DateTime(2021,08,22,09,15,0)},
                new CustomerDataClass(){Id=4, CustomerName="Harshitha", AmntToGive=0,AmntToRecieve=1000, dateTime=new DateTime(2021,08,11,09,15,0)},
                new CustomerDataClass(){Id=5,CustomerName="Abhimanyu", AmntToGive=0,AmntToRecieve=700,dateTime=new DateTime(2021,08,05,15,15,0) }
            };

        }

        public CustomerDataClass GetCustomer(int Id)
        {
            return _customersList.FirstOrDefault(e => e.Id == Id);
        }

        public List<CustomerDataClass> GetListofCustomers()
        {
            return _customersList;
        }
    }
}
