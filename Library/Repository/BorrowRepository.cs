using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    class BorrowRepository : IBorrowRepository
    {
        public bool borrowBook(int book_id, int customer_id, DateTime Recieve_Date, DateTime Return_Date)
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = String.Format("INSERT INTO Rent(C_Id,B_Id) VALUES({0},{1})",
                    book_id,  customer_id);
                return db.createQuery(query);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool returnBook(int book_id)
        {
            throw new NotImplementedException();
        }
    }
}
