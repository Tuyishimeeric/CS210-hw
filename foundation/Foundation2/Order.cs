using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const decimal USA_Shipping_Cost = 5.00m;
    private const decimal International_Shipping_Cost = 35.00m;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal TotalCost()
    {
        decimal total = 0;

        foreach (var product in products)
        {
            total += product.TotalCost();
        }

        total += customer.LivesInUSA() ? USA_Shipping_Cost : International_Shipping_Cost;

        return total;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().FullAddress()}";
    }
}
