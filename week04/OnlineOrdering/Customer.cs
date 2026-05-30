using System;

public class Customer
{
    private string _custName;
    private Address _address;

    public Customer(string custName, Address address)
    {
        _custName = custName;
        _address = address;
    }

    public string custName { get => _custName; set => _custName = value; }
    public Address address { get => _address; set => _address = value; }

    public bool LivesInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else { return false; }
    }
}