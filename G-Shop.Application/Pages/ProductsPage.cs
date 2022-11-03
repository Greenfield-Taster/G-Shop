using G_Shop.Application.Helpers;
using G_Shop.Database.Repositories;
using G_Shop.Domain.Products;

namespace G_Shop.Application.Pages;

public partial class ProductsPage : UserControl
{
    private readonly List<Product> _products = new(); // Список всех товаров из базы
    private readonly ProductsRepository _productsRepository = new(); // Предоставляет доступ к базе данных

    public ProductsPage()
    {
        InitializeComponent();
    }

    private void ProductsPage_Load(object sender, EventArgs e)
    {
        List<Product> databaseProducts = _productsRepository.GetProducts();
        _products.AddRange(databaseProducts);

        DisplayProducts();
    }

    private void DisplayProducts()
    {
        foreach (Product product in _products)
        {
            Image image = DatabaseImageConverter.ByteArrayToImage(product.ImageBytes);
            string imageKey = $"key{product.Id}";

            imageList.Images.Add(imageKey, image);

            ListViewItem listViewItem = new ListViewItem(product.Name, imageKey);
            listViewPoducts.Items.Add(listViewItem);
        }
    }
}
