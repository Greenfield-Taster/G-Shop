using G_Shop.Database.DatabaseRepositories;
using G_Shop.Database.Interfaces;

namespace G_Shop.Database;

public static class RepositoryProvider
{
    public static readonly IProductsRepository ProductsRepository = new ProductsRepository();
    public static readonly IWarehouseRepository WarehouseRepository = new WarehouseRepository();
    public static readonly IUsersRepository UsersRepository = new UsersRepository();
    public static readonly IOperationsRepository OperationsRepository = new OperationsRepository();
    public static readonly ICustomersRepository CustomersRepository = new CustomersRepository();
}