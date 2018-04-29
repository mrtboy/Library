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
                string query = String.Format("INSERT INTO Customer(C_Name, C_Email, C_Phone, C_Address) VALUES('{0}','{1}','{2}','{3}')",
                    customer.Name, customer.Email, customer.Phone, customer.Address);
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
