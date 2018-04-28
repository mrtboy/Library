using System;
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
        public DateTime Dob { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Customer() { }

        public Customer(string name, DateTime dob,string address, string email, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Dob = dob;
            this.Email = email;
            this.Phone = phone;
        }
    }
}
