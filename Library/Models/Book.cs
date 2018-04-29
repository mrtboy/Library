using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Book
    {
        //string id;

        //public string Id
        //{
        //    get { return id; }
        //    set { id = Guid.NewGuid().ToString(); }
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Isbn { get; set; }
        public string Author{ get; set; }
        public string Publisher{ get; set; }
        public int Edition{ get; set; }
        public string BookShell{ get; set; }
        public int RowNo{ get; set; }
        public int ColumnNo{ get; set; }
        public bool IsAvailable { get; set; }

        public Book(string name, string isbn, string author, string publisher, int edition,
            string bookshell, int rowNo, int columnNo)
        {
            this.Name= name;
            this.Isbn = isbn;
            this.Author = author;
            this.Publisher = publisher;
            this.Edition = edition;
            this.BookShell = bookshell;
            this.RowNo = rowNo;
            this.ColumnNo = columnNo;
            this.IsAvailable = true;
        }

        public Book() { }

    }
}
