using G_Shop.Domain.Sales;

namespace G_Shop.Database.Interfaces;

public interface IOperationsRepository
{
    void AddNewSale(Sale sale);
    void ClearDatabase();
    int GetNextCheckNumber();
}