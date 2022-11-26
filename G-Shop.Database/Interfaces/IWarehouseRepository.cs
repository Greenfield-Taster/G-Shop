using G_Shop.Domain.Warehouses;

namespace G_Shop.Database.Interfaces;

public interface IWarehouseRepository
{
    void AddNewWarehouse(Warehouse warehouse);
    Warehouse? GetWarehouseByProductId(int productId);
    void RemoveWarehouse(int id);
    void UpdateWarehouse(Warehouse warehouse);
}