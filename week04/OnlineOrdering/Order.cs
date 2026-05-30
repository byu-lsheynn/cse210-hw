using System;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (var item in _products)
        {
            totalCost += item.GetTotalProductCost();
        }

        if (_customer.LivesInUSA())
        {
            totalCost += 5;
        }
        else { totalCost += 35; }


        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("=== PACKING LABEL ===");

        foreach (var product in _products)
        {
            sb.AppendLine($"Product: {product.productName} ID: {product.productID}");
        }

        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("=== SHIPPING LABEL ===");

        sb.AppendLine($"Customer Name: {_customer.custName}");
        sb.AppendLine($"Address: { _customer.address.GetFullAddress()}");

        return sb.ToString();
    }
}