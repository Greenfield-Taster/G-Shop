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
        throw new NotImplementedException();
    }

    public List<Product> GetProducts()
    {
        List<Product> products = new();

        SqlConnection connection = new SqlConnection(DatabaseConnector.ConnectionString);
        connection.Open();

        SqlCommand command = connection.CreateCommand();
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

        connection.Close();
        return products;
    }

    public void UpdateProduct(Product product)
    {
        throw new NotImplementedException();
    }
}