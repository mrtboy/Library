using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using System.Data;

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


        public bool SaveBook(Book book)
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = String.Format("INSERT INTO Book(B_Name, B_Isbn, B_Author, B_Publisher, B_Edition, B_BookShell, B_RowNo, B_ColumnNo, B_IsAvailable) VALUES('{0}','{1}','{2}','{3}',{4},'{5}',{6},{7}, {8})",
                    book.Name, book.Isbn, book.Author, book.Publisher, book.Edition, book.BookShell, book.RowNo, book.ColumnNo, 1);
                return db.createQuery(query);
            }catch(Exception)
            {
                return false;
            }
        }

        public DataSet GetBooks()
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = "select * from Book";
                   
                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet FindBook(string bookName)
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = String.Format("select * from Book WHERE B_Name LIKE '{0}%'", bookName);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}

