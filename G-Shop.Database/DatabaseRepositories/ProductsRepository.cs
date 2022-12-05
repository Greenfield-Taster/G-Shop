using Dapper;
using G_Shop.Database.DatabaseRepositories.Helpers;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Products;
using G_Shop.Domain.Warehouses;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace G_Shop.Database.DatabaseRepositories;

internal class ProductsRepository : IProductsRepository
{
    public int AddNewProduct(Product product)
    {
        string sql = @"INSERT INTO Products (Name, Country, Category, Price, Image, Description, Season)
                            VALUES (@Name, @Country, @Category, @Price, @ImageBytes, @Description, @Season)
                            SELECT Id FROM Products 
                            WHERE Id =  (SELECT MAX(Id) FROM Products);";

        DatabaseConnector.Connection.Execute(sql, product);

        string sqlReturnLastId = "SELECT MAX(Id) FROM Products;";
        int productLastId = DatabaseConnector.Connection.QuerySingleOrDefault<int>(sqlReturnLastId);

        return productLastId;
    }

    public void DeleteProduct(int id)
    {
        string sql = $"DELETE FROM Products WHERE Id = {id};";
        DatabaseConnector.Connection.Execute(sql);
    }

    public List<Product> GetProducts()
    {
        List<Product> products = new();

        DatabaseConnector.Connection.Open();

        SqlCommand command = DatabaseConnector.Connection.CreateCommand();
        command.CommandText = "SELECT * FROM Products;";

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            int id = reader.GetInt32("Id");
            string name = reader.GetString("Name");
            string country = reader.GetString("Country");
            Category category = (Category)reader.GetInt32("Category");
            decimal price = reader.GetDecimal("Price");
            byte[] image = reader.GetStream("Image").GetBytes();
            string description = reader.GetString("Description");
            Season season = (Season)reader.GetInt32("Season");

            Product product = new(id, name, country, category, price, image, description, season);
            products.Add(product);
        }

        DatabaseConnector.Connection.Close();
        return products;
    }

    public void UpdateProduct(Product product)
    {
        string sqlQuery = @"UPDATE Products SET 
                                            Name = @Name, 
                                            Country = @Country, 
                                            Category = @Category, 
                                            Price = @Price, 
                                            Image = @ImageBytes,
                                            Description = @Description, 
                                            Season = @Season
                                            WHERE Id = @Id;";

        DatabaseConnector.Connection.Execute(sqlQuery, product);
    }
}