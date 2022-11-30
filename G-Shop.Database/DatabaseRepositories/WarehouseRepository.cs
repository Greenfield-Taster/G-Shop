using Dapper;
using G_Shop.Database.DatabaseRepositories.Helpers;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Products;
using G_Shop.Domain.Warehouses;
using System.Collections.Generic;

namespace G_Shop.Database.DatabaseRepositories;
internal class WarehouseRepository : IWarehouseRepository
{
    public void AddNewWarehouse(Warehouse warehouse)
    {
        string sql = @"INSERT INTO Warehouse(ProductId, XS, S, M, L, XL, XXL, XXXL) 
                        VALUES( @ProductId, @XS, @S, @M, @L, @XL, @XXL, @XXXL)";

        DatabaseConnector.Connection.Execute(sql, warehouse);
    }

    public Warehouse GetWarehouseByProductId(int productId)
    {
        string sqlQuery = $"SELECT * FROM Warehouse WHERE ProductId = {productId};";
        Warehouse? warehouse = DatabaseConnector.Connection.QuerySingleOrDefault<Warehouse>(sqlQuery);

        if (warehouse is null) 
        {
            warehouse = new Warehouse(productId, 0, 0, 0, 0, 0, 0, 0);
        }

        return warehouse;
    }

    public void RemoveWarehouse(int id)
    {
        string sql = $"DELETE FROM Warehouse WHERE ProductId = {id};";
        DatabaseConnector.Connection.Execute(sql);
    }

    public void UpdateWarehouse(Warehouse warehouse)
    {
        string sql = @"UPDATE Warehouse SET 
                                        XS = @XS, 
                                        S = @S, 
                                        M = @M, 
                                        L = @L, 
                                        XL = @XL, 
                                        XXL = @XXL, 
                                        XXXL = @XXXL 
                                        WHERE ProductId = @ProductId;";

        DatabaseConnector.Connection.Execute(sql, warehouse);
    }
}