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
            listViewItem.Tag = product.Id;

            listViewPoducts.Items.Add(listViewItem);
        }
    }

    private void ListViewPoducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listViewPoducts.SelectedItems.Count == 0)
        {
            return;
        }

        ListViewItem listViewItem = listViewPoducts.SelectedItems[0];
        int selectedProductId = Convert.ToInt32(listViewItem.Tag);

        Product selectedProduct = _products.First(item => item.Id == selectedProductId);
        productControl1.DisplayProductInfo(selectedProduct);
    }
}