using G_Shop.Database.Interfaces;
using G_Shop.Domain.Sales;

namespace G_Shop.Database.InMemoryRepositories;

internal class OperationsRepository : IOperationsRepository
{
    private readonly List<Sale> databaseSales = new()
    {
        new Sale(1, DateTime.Now, 1, 1, 1, 200, 1, 1),
        new Sale(2, DateTime.Now, 2, 2, 1, 1400, 2, 2),
        new Sale(3, DateTime.Now, 3, 1, 1, 780, 3, 3),
    };

    public void AddNewSale(Sale addedSale)
    {
        addedSale.Id = databaseSales.Count + 1;
        databaseSales.Add(addedSale);
    }

    public void ClearDatabase()
    {
        throw new NotImplementedException();
    }

    public int GetNextCheckNumber()
    {
        int maxCheckId = databaseSales.Max(sale => sale.ChekId);
        return maxCheckId + 1;
    }
}