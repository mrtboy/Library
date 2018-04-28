using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    interface IBookRepository
    {
        bool SaveBook(int id);
        bool DeleteBook(int id);
        bool EditBook();
    }
}
