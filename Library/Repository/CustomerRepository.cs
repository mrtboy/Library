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
                string query = "INSERT INTO Customer(Customer_Name) VALUES('" + customer.Name + "')";
                DbConnection db = DbConnection.createConnection();
                return db.createQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
