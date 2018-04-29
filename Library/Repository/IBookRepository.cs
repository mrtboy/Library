using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repository
{
    interface IBookRepository
    {
        bool SaveBook(Book book);
        bool DeleteBook(int id);
        DataSet GetBooks();
        DataSet FindBook(string bookName);
    }
}
