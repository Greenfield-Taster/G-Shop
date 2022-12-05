using Dapper;
using G_Shop.Database.DatabaseRepositories.Helpers;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Sales;

namespace G_Shop.Database.DatabaseRepositories;

internal class OperationsRepository : IOperationsRepository
{
    public void AddNewSale(Sale sale)
    {
        string sql = @"INSERT INTO Sales(ProductId,DataTime, UserId, Amount, Price, ChekId, CustomerId) 
                        VALUES(@ProductId, @DateAndTime, @UserId, @Amount, @Price, @ChekId, @CustomerId);";
        DatabaseConnector.Connection.Execute(sql, sale);
    }

    public int GetNextCheckNumber()
    {
        return 2;
    }

    public void ClearDatabase()
    {
        string sql = "DELETE FROM Sales WHERE Id>0;";
        DatabaseConnector.Connection.Execute(sql);
    }
}