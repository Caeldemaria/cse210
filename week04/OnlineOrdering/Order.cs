using System;

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
        double total = 0;  
        foreach (var product in _products)  
        {  
            total += product.TotalCost();  
        }  

        // Add shipping cost  
        double shippingCost = _customer.LivesInUSA() ? 5 : 35;  
        total += shippingCost;  

        return total;  
    }  

    public string GetPackingLabel()  
    {  
        string packingLabel = "Packing Label:\n";  
        foreach (var product in _products)  
        {  
            packingLabel += product.GetProductInfo() + "\n";  
        }  
        return packingLabel.Trim();  
    }  

    public string GetShippingLabel()  
    {  
        return "Shipping Label:\n" + _customer.GetCustomerInfo();  
    }  
}  
