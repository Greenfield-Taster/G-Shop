using System.Data;

namespace G_Shop.Domain.Products;

public class Product
{
    public Product(int id, string name, string country, Category category, decimal price, byte[] imageBytes, string description, Season season)
    {
        Id = id;
        Name = name;
        Country = country;
        Category = category;
        Price = price;
        ImageBytes = imageBytes;
        Description = description;
        Season = season;
    }

    public int Id { get; private set; }

    public string Name { get; private set; }
    
    public string Country { get; private set; }
    
    public Category Category { get; private set; }
    
    public decimal Price { get; private set;}
    
    public byte[] ImageBytes { get; private set; }
    
    public string Description { get; private set; }

    public Season Season { get; private set; }
}