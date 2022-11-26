using G_Shop.Database.Interfaces;
using G_Shop.Domain.Warehouses;

namespace G_Shop.Database.DatabaseRepositories;

internal class WarehouseRepository : IWarehouseRepository
{
    public void AddNewWarehouse(Warehouse warehouse)
    {
        throw new NotImplementedException();
    }

    // TODO: change warehouse sizes
    public Warehouse? GetWarehouseByProductId(int productId)
    {
        return new Warehouse(productId, 3,2,5,4,3,2,3);
    }

    public void RemoveWarehouse(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateWarehouse(Warehouse warehouse)
    {
        throw new NotImplementedException();
    }
}