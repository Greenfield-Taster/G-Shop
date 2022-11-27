﻿using Dapper;
using G_Shop.Database.DatabaseRepositories.Helpers;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Products;
using System.Data;
using System.Data.SqlClient;

namespace G_Shop.Database.DatabaseRepositories;

internal class ProductsRepository : IProductsRepository
{
    public int AddNewProduct(Product product)
    {
        throw new NotImplementedException();
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