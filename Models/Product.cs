using System;

namespace AmazonToo.Models
{
    public class Product
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Image { get; set; }
        public bool IsPrime { get; set; }
        public OrderItem OrderItem { get; set; }
    }
}
