using G_Shop.Domain.Warehouses;

namespace G_Shop.Database.Repositories;

public class WarehouseRepository
{
    private readonly List<Warehouse> dataBaseWarehouse = new()
    {
        new Warehouse(1,3,2,5,4,3,6,5),
        new Warehouse(2,5,6,3,6,8,9,4),
        new Warehouse(3,6,4,2,1,6,3,4),
        new Warehouse(4,3,7,5,7,4,3,0),
        new Warehouse(5,7,5,3,7,4,3,8),
    };

    public Warehouse? GetWarehouseByProductId(int productId)
    {
        Warehouse? foundWarehouse = dataBaseWarehouse.FirstOrDefault(warehouse => warehouse.ProductId == productId); // Поиск склада по Id продукта
        return foundWarehouse;
    }

    public void UpdateWarehouse(Warehouse changedWarehouse)
    {
        for (int index = 0; index < dataBaseWarehouse.Count; index++)
        {
            if (changedWarehouse.ProductId == dataBaseWarehouse[index].ProductId)
            {
                dataBaseWarehouse.RemoveAt(index);
                dataBaseWarehouse.Insert(index, changedWarehouse);
                return;
            }
        }
    }

    public void RemoveWarehouse(int productId)
    {
        Warehouse foundWarehouse = GetWarehouseByProductId(productId);

        if (foundWarehouse is null)
        {
            return;
        }

        dataBaseWarehouse.Remove(foundWarehouse);
    }

    public void AddNewWarehouse(Warehouse warehouseNew)
    {
        dataBaseWarehouse.Add(warehouseNew);
    }
}