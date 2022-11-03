using G_Shop.Database.Properties;
using G_Shop.Domain.Products;

namespace G_Shop.Database.Repositories;

public class ProductsRepository
{
    private readonly List<Product> dataBaseProducts = new()
    {
        new Product(1,"Штаны", "Украина", "Мужское", 200, Resources.jacket3),
        new Product(2,"Шорты", "Украина", "Мужское", 1400, Resources.bag),
        new Product(3,"Кофта", "Украина", "Женское", 780, Resources.bag2),
        new Product(4,"Юбка", "Украина", "Женское", 1400, Resources.jacket),
        new Product(5,"Блузка", "Украина", "Женское", 15000, Resources.jacket2),
    };

    public List<Product> GetProducts()
    {
        return dataBaseProducts;
    }
}