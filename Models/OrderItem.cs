using System;

namespace AmazonToo.Models
{
    public class OrderItem
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public uint ProductId { get; set; }
        public Product Product { get; set; }
        public uint Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
