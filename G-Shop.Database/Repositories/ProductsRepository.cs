using G_Shop.Domain.Products;

namespace G_Shop.Database.Repositories;

public class ProductsRepository
{
    private readonly List<Product> dataBaseProducts = new()
    {
        new Product(1,"Штаны", "Украина", "Мужское", 200),
        new Product(2,"Шорты", "Украина", "Мужское", 1400),
        new Product(3,"Кофта", "Украина", "Женское", 780),
        new Product(4,"Юбка", "Украина", "Женское", 1400),
        new Product(5,"Блузка", "Украина", "Женское", 15000),
    };

    public List<Product> GetProducts()
    {
        return dataBaseProducts;
    }
}