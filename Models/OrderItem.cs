using System;

class OrderItem
{
    public Order Order { get; }
    public Product Product { get; set; }
    public UInt16 Quantity { get; set; }
    public Decimal Price { get; set; }
}