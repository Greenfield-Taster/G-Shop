using G_Shop.Database.Properties;
using G_Shop.Domain.Products;

namespace G_Shop.Database.Repositories;

public class ProductsRepository
{
    private readonly List<Product> dataBaseProducts = new()
    {
        new Product(9,"Блакитна куртка", "Украина", Category.Woman, 200, Resources.jacket3, "мукмкмук умлп м кди мкдуи лакд иавьаи ва и", Season.Autumn),
        new Product(2,"Чорна сумка", "Украина", Category.Man, 1400, Resources.bag, "умукмкум умлп м кди мкдуи лакд иавьаи ва и", Season.Winter),
        new Product(7,"Дорожна валіза", "Украина",Category.Man, 780, Resources.bag2, "цууцвц умлп м кди мкдуи лакд иавьаи ва и", Season.Spring),
        new Product(4,"Чорна куртка", "Украина", Category.Woman, 1400, Resources.jacket, "ісумум умлп м кди мкдуи лакд иавьаи ва и", Season.Summer),
        new Product(5,"Бежева безрукавка", "Украина", Category.Woman, 15000, Resources.jacket2, "цуацу3 умлп м кди мкдуи лакд иавьаи ва и", Season.Autumn),
    };

    public List<Product> GetProducts()
    {
        return dataBaseProducts;
    }

    public void UpdateProduct(Product changedProduct)
    {
        for (int index = 0; index < dataBaseProducts.Count; index++)
        {
            if (changedProduct.Id == dataBaseProducts[index].Id)
            {
                dataBaseProducts[index] = changedProduct;
                return;
            }   
        }
    }
}