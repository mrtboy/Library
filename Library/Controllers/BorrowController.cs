using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Repository;

namespace Library.Controllers
{
    class BorrowController : IBorrowController
    {
        IBorrowRepository repo;
        public bool borrowBook(int book_id, int customer_id, DateTime Recieve_Date, DateTime Return_Date)
        {
            repo = new BorrowRepository();
            return repo.borrowBook( book_id,  customer_id,  Recieve_Date,  Return_Date);
        }

        public bool returnBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
