﻿using G_Shop.Domain.Products;

namespace G_Shop.Database.Interfaces;

public interface IProductsRepository
{
    int AddNewProduct(Product product);
    void DeleteProduct(int id);

    List<Product> GetProducts();
    void SearchProduct(string text);
    void UpdateProduct(Product product);
}