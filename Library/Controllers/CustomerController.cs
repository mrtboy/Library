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
        public bool AddNewCustomer(Customer customer)
        {
            customerRepository = new CustomerRepository();
            return customerRepository.SaveCustomer(customer);
        }

        public bool RemoveCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
