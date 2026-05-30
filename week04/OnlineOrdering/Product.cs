using System;

public class Product
{
    public string _productName;
    public string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int qty)
    {
        _productName = name;
        _productID = id;
        _price = price;
        _quantity = qty;
    }

    public double GetTotalProductCost()
    {
        return _price * _quantity;
    }
}