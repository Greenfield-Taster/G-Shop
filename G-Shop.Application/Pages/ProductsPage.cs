using G_Shop.Database.Repositories;
using G_Shop.Domain.Products;

namespace G_Shop.Application.Pages;

public partial class ProductsPage : UserControl
{
    private readonly List<Product> _products = new (); // Список всех товаров из базы
    private readonly ProductsRepository _productsRepository = new (); // Предоставляет доступ к базе данных

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
        foreach (var product in _products)
        {
            ListViewItem listViewItem = new ListViewItem(product.Name, "key1");
            listViewPoducts.Items.Add(listViewItem);
        }
    }
}
