using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Controllers
{
    interface IBookController
    {
        bool AddNewBook(Book book);
        bool EditBook(int id);
        DataSet ShowBooks();
        DataSet SearchBook(string bookName);
    }
}
