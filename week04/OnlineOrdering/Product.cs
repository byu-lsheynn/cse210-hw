using System;

public class Product
{
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int qty)
    {
        _productName = name;
        _productID = id;
        _price = price;
        _quantity = qty;
    }

    public string productName { get => _productName; set => _productName = value; }
    public string productID { get => _productID; set => _productID = value; }

    public double GetTotalProductCost()
    {
        return _price * _quantity;
    }
}