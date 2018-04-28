using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repository;

namespace Library.Controllers
{
    class CustomerController : ICustomerController
    {
        ICustomerRepository customerRepository;
        Customer newCustomer;
        public bool AddNewCustomer(string name, string address)
        {
            newCustomer = new Customer();
            newCustomer.Name = name;
            newCustomer.Address = address;
            customerRepository = new CustomerRepository();
            
            return customerRepository.SaveCustomer(newCustomer);
        }

        public bool RemoveCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
