using System;
using System.Collections.Generic;

class Order
{
    public String Id { get; set; }
    public List<OrderItem> Items { get; set; }
    public Decimal Total { get; set; }
    public Boolean IsProcessed { get; set; }
    public Boolean IsShipped { get; set; }
    public User User { get; }
}