using System;

namespace AmazonToo.Models
{
    public class UserAddress
    {
        public Guid UserId { get; set; }
        public User User { get; set;  }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Province Province { get; set; }
        public Country Country { get; set; }
    }
}
