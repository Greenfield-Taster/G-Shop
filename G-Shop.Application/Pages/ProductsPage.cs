using G_Shop.Application.Controls;
using G_Shop.Application.Helpers;
using G_Shop.Application.Properties;
using G_Shop.Database.Repositories;
using G_Shop.Domain.Products;

namespace G_Shop.Application.Pages;

public partial class ProductsPage : UserControl
{
    private readonly List<Product> _products = new(); // Список всех товаров из базы
    private readonly ProductsRepository _productsRepository = RepositoryProvider.ProductsRepository; // Предоставляет доступ к базе данных

    public ProductsPage()
    {
        InitializeComponent();

        DisplayCategoriesToComboBox();
    }

    private int GetIndexOfAllCategory()
    {
        return comboBoxCategory.Items.Count - 1;
    }

    private void DisplayCategoriesToComboBox()
    {
        comboBoxCategory.Items.AddRange(Enum.GetNames<Category>());
        comboBoxCategory.Items.Add("All");
        comboBoxCategory.SelectedIndex = GetIndexOfAllCategory();
    }

    private void ProductsPage_Load(object sender, EventArgs e)
    {
        ReloadAndDisplayProductsFormDatabase();
    }

    private void ReloadAndDisplayProductsFormDatabase()
    {
        ReloadProductsFromDatabase();
        DisplayProductsToListView(_products);
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

    private void DisplayProductsToListView(List<Product> products)
    {
        listViewPoducts.Clear();
        imageList.Images.Clear();

        foreach (Product product in products)
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
        productEditControl1.Mode = ProductControlMode.Edit;

        productEditControl1.SubscribeForChanges(ReloadAndDisplayProductsFormDatabase);
    }

    private void ReloadProductsFromDatabase()
    {
        _products.Clear();

        List<Product> databaseProducts = _productsRepository.GetProducts();
        _products.AddRange(databaseProducts);
    }

    private void PictureBoxDelete_Click(object sender, EventArgs e)
    {
        Product? product = GetSelectedProduct();

        if (product is null)
        {
            return;
        }

        _productsRepository.DeleteProduct(product.Id);
        ReloadAndDisplayProductsFormDatabase();
    }

    private void PictureBoxAdd_Click(object sender, EventArgs e)
    {
        Product emptyProduct = new(0, "", "", Category.Man, 0, DatabaseImageConverter.ImageToByteArray(Resources.empty_profile), "", Season.Autumn);

        productEditControl1.BringToFront();
        productEditControl1.DisplayEditProductInfo(emptyProduct); 
        productEditControl1.Mode = ProductControlMode.Add;

        productEditControl1.SubscribeForChanges(ReloadAndDisplayProductsFormDatabase);
    }

    private List<Product> FilterProductByCategory(Category selectedCategory)
    {
        return _products
            .Where(product => product.Category == selectedCategory)
            .ToList();
    }

    private void ComboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (comboBoxCategory.SelectedIndex == GetIndexOfAllCategory())
        {
            DisplayProductsToListView(_products);
            SetSelectedProduct();
            
            return;
        }
        
        Category selectedCategory = (Category)comboBoxCategory.SelectedIndex;

        List<Product> productsOfSpecificCategory = FilterProductByCategory(selectedCategory);
        DisplayProductsToListView(productsOfSpecificCategory);
        SetSelectedProduct();
    }

    private void productControl1_Load(object sender, EventArgs e)
    {

    }
}