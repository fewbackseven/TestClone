using System;
using System.Collections.Generic;
using System.Text;
using MvvmHelpers;
using TestClone.Model;

namespace TestClone.ViewModel
{
    public class HomePage1ViewModel : BaseViewModel
    {
        private readonly MockCustomerClass _customerRepository;
        private List<CustomerDataClass> _mockCustomers;

        public HomePage1ViewModel()
        {
            
        }

        public  List<CustomerDataClass> AllCustomers
        {
            get { return _mockCustomers=getAllCustomer() ; }
        }

        public string getCustomer()
        {
            return _customerRepository.GetCustomer(1).CustomerName;
        }

        public List<CustomerDataClass> getAllCustomer()
        {
            return _customerRepository.GetListofCustomers();
        }
    }
}
