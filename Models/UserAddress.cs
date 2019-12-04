using System;

class UserAddress
{
    public User User { get; }
    public String AddressLine1 { get; set; }
    public String AddressLine2 { get; set; }
    public Province Province { get; set; }
    public Country Country { get; set; }
}