using System;
using System.Collections.Generic;

namespace AmazonToo.Models
{
    class Order
    {
        public Guid Id { get; set; }
        public decimal Total { get; set; }
        public bool IsProcessed { get; set; }
        public bool IsShipped { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<OrderItem> Items { get; set; }
    }
}
