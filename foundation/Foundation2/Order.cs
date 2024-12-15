using System.Diagnostics.CodeAnalysis;
using System.Reflection.Emit;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddItem(Product product)
    {
         _products.Add(product);
    }

    public double TotalPrice()
    {
        double sum = 0;

        foreach (Product product in _products)
        {
            sum += product.GetCost();
        }
        return sum;
    }

    public List<Product> Products {get; set;}

    public string PackLabel()
    {
        string label = "";

        foreach (var product in _products)
        {
            label += $"Product ID: {product.Id()}\n";
            label += $"Product Name: {product.Name()}\n";
            label += $"Quantity: {product.Quantity()}\n";
        }

        return label;
    }

    public string ShipLabel()
    {
        string label = "";

        label += $"Name: {_customer.GetName()}\n";
        label += $"Address: {_customer.GetAddress()}\n";
        return label;
    }




    
}