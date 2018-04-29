using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repository;
using System.Data;

namespace Library.Controllers
{
    class BookController : IBookController
    {
        IBookRepository repo;
        public bool AddNewBook(Book book)
        {
            repo = new BookRepository();
            return repo.SaveBook(book);
        }

        public bool EditBook(int id)
        {
            throw new NotImplementedException();
        }
        public DataSet ShowBooks()
        {
            repo = new BookRepository();
            return repo.GetBooks();
        }

    }
}
