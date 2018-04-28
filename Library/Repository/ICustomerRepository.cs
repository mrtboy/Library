﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repository
{
    interface ICustomerRepository
    {
        bool SaveCustomer(Customer customer);
    }
}
