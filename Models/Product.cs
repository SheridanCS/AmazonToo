using System;

namespace AmazonToo.Models
{
    class Product
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Image { get; set; }
        public bool IsPrime { get; set; }
    }
}
