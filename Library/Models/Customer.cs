﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Book { get; set; }
    }
}
