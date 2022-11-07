using G_Shop.Application.Helpers;
using G_Shop.Database.Repositories;
using G_Shop.Domain.Products;
using System.Windows.Forms;

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
        SetSelectedProduct();
    }

    private void SetSelectedProduct()
    {
        if (listViewPoducts.Items.Count == 0)
        {
            return;
        }

        listViewPoducts.Items[0].Selected = true;
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

    private Product? GetSelectedProduct()
    {
        if (listViewPoducts.SelectedItems.Count == 0)
        {
            return null;
        }

        ListViewItem listViewItem = listViewPoducts.SelectedItems[0];
        int selectedProductId = Convert.ToInt32(listViewItem.Tag);

        Product selectedProduct = _products.First(item => item.Id == selectedProductId); // Поиск товара по Id
        return selectedProduct;
    }

    private void ListViewPoducts_SelectedIndexChanged(object sender, EventArgs e)
    {
        Product? selectedProduct = GetSelectedProduct();

        if (selectedProduct is null)
        {
            return;
        }

        productControl1.DisplayProductInfo(selectedProduct); 
    }

    private void PictureBoxChange_Click(object sender, EventArgs e)
    {
        productEditControl1.BringToFront();

        Product? selectedProduct = GetSelectedProduct();

        if (selectedProduct is null)
        {
            return;
        }

        productEditControl1.DisplayEditProductInfo(selectedProduct);
    }
}