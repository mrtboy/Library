using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Isbn { get; set; }
        public string Author{ get; set; }
        public string Publisher{ get; set; }
        public int Edition{ get; set; }
        public int BookShell{ get; set; }
        public int RowNo{ get; set; }
        public int ColumnNo{ get; set; }
        public bool IsAvailable { get; set; }

    }
}
