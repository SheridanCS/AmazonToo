using System;
using System.Collections.Generic;

namespace AmazonToo.Models
{
    class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserAddress Address { get; set; }
        public bool IsPrimeMember { get; set; }
        public List<Order> Orders { get; set;  }
    }

}
