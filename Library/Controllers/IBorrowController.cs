using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controllers
{
    interface IBorrowController
    {
        bool borrowBook(int bookId, int customerId);
        bool returnBook(int bookId);

    }
}
