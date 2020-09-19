using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        public string Holder { get; set; }

        public int Balance { get; set; }
    }
}
