using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool SaveBook(int id)
        {

            return true;
        }
    }
}
