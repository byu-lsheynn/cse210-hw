using System;

public class Customer
{
    public string _custName;
    public Address _address;

    public Customer(string custName, Address address)
    {
        _custName = custName;
        _address = address;
    }

    public bool LivesInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else { return false; }
    }
}