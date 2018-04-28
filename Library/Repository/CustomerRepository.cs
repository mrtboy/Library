using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repository
{
    class CustomerRepository : ICustomerRepository
    {
        public bool SaveCustomer(Customer customer)
        {
            try{
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
