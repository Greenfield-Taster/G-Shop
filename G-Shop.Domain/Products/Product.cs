using System.Data;

namespace G_Shop.Domain.Products;

public class Product
{
    private int id;
    private string name;
    private string country;
    private string category;
    private decimal price;

    public Product(int id, string name, string country, string category, decimal price)
    {
        this.id = id;
        this.name = name;
        this.country = country;
        this.category = category;
        this.price = price;
    }

    public string Name => name;

}