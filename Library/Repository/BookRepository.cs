using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repository
{
    class BookRepository : IBookRepository
    {
        public bool DeleteBook(int id)
        {
            DbConnection db = DbConnection.createConnection();
            string query = String.Format("DELETE FROM Book Where Bood_Id = {0}", id);
            return db.createQuery(query);
        }

        public bool EditBook()
        {
            throw new NotImplementedException();
        }

        public bool RentBook()
        {
            throw new NotImplementedException();
        }

        public bool SaveBook(Book book)
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = String.Format("INSERT INTO Book(B_Name, B_Isbn, B_Author, B_Publisher, B_Edition, B_BookShell, B_RowNo, B_ColumnNo) VALUES('{0}','{1}','{2}','{3}',{4},'{5}',{6},{7})",
                    book.Name, book.Isbn, book.Author, book.Publisher, book.Edition, book.BookShell, book.RowNo, book.ColumnNo);
                return db.createQuery(query);
            }catch(Exception e)
            {
                return false;
            }
        }
    }
}

