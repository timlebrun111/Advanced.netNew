﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Library.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int CustomerId { get; set; }
        public string CustomerFirst { get; set; }
        public string CustomerLast { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
