using System;
using System.Collections.Generic;

class User
{
    public String Id { get; set; }
    public String Name { get; set; }
    public String Email { get; set; }
    public UserAddress Address { get; set; }
    public Boolean IsPrimeMember { get; set; }
    public List<Order> Orders { get; }
}