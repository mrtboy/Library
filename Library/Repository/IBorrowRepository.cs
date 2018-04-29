using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    interface IBorrowRepository
    {
        bool borrowBook(int book_id,int customer_id,DateTime Recieve_Date,DateTime Return_Date);
        bool returnBook(int book_id);
    }
}
