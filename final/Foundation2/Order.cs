using System;
using System.Collections.Generic;
using System.Text;
class Order
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
        foreach (var product in _products)
        {
            totalCost += product.CalculateTotalPrice();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in _products)
        {
            label.AppendLine($"Name: {product.GetName()}, Product ID: {product.GetProductId()}");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        Address customerAddress = _customer.GetAddress();
        return customerAddress.GetFullAddress();
    }
}