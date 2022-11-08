namespace G_Shop.Database.Repositories;

public static class RepositoryProvider
{
    public static readonly ProductsRepository ProductsRepository = new();
    public static readonly WarehouseRepository WarehouseRepository = new();
}