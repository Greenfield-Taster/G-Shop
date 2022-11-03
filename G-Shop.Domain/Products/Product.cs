using System.Data;

namespace G_Shop.Domain.Products;

public class Product
{
    private int id;
    private string name;
    private string country;
    private string category;
    private decimal price;
    private byte[] imageBytes;

    public Product(int id, string name, string country, string category, decimal price, byte[] imageBytes)
    {
        this.id = id;
        this.name = name;
        this.country = country;
        this.category = category;
        this.price = price;
        this.imageBytes = imageBytes;
    }

    public string Name => name;
    public byte[] ImageBytes => imageBytes;
    public int Id => id;
}