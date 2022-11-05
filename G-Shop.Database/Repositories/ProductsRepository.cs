using G_Shop.Database.Properties;
using G_Shop.Domain.Products;

namespace G_Shop.Database.Repositories;

public class ProductsRepository
{
    private readonly List<Product> dataBaseProducts = new()
    {
        new Product(1,"Штаны", "Украина", Category.Woman, 200, Resources.jacket3, "Описание1 умлп м кди мкдуи лакд иавьаи ва и", Season.Autumn),
        new Product(2,"Шорты", "Украина", Category.Man, 1400, Resources.bag, "Описание1 умлп м кди мкдуи лакд иавьаи ва и", Season.Winter),
        new Product(3,"Кофта", "Украина",Category.Man, 780, Resources.bag2, "Описание1 умлп м кди мкдуи лакд иавьаи ва и", Season.Spring),
        new Product(4,"Юбка", "Украина", Category.Woman, 1400, Resources.jacket, "Описание1 умлп м кди мкдуи лакд иавьаи ва и", Season.Summer),
        new Product(5,"Блузка", "Украина", Category.Woman, 15000, Resources.jacket2, "Описание1 умлп м кди мкдуи лакд иавьаи ва и", Season.Autumn),
    };

    public List<Product> GetProducts()
    {
        return dataBaseProducts;
    }
}