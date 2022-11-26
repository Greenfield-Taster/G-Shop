using G_Shop.Application.Helpers;
using G_Shop.Database;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Products;

namespace G_Shop.Application.Controls;

public partial class ProductEditControl : UserControl
{
    private readonly IProductsRepository _productsRepository = RepositoryProvider.ProductsRepository;
    private int productId;
    private Action? _updateProductPageCallback;

    public ProductEditControl()
    {
        InitializeComponent();

        comboBoxCategory.Items.AddRange(Enum.GetNames<Category>());
        comboBoxSeason.Items.AddRange(Enum.GetNames<Season>());
    }

    public ProductControlMode Mode { get; set; } = ProductControlMode.Edit;

    /// <summary>
    /// Принимает продукт и выводит информацию о нем
    /// </summary>
    /// <param name="selectedProduct">Продукт который будет отображен</param>
    internal void DisplayEditProductInfo(Product selectedProduct)
    {
        textBoxName.Text = selectedProduct.Name;
        comboBoxCategory.SelectedIndex = (int)selectedProduct.Category;
        textBoxPrice.Text = selectedProduct.Price.ToString();
        comboBoxSeason.SelectedIndex = (int)selectedProduct.Season;
        richTextBoxDescription.Text = selectedProduct.Description;
        sizesControl.DisplaySizes(selectedProduct.Id, UpdateSizesCount);
        pictureBox1.Image = DatabaseImageConverter.ByteArrayToImage(selectedProduct.ImageBytes);
        productId = selectedProduct.Id;
    }

    private void UpdateSizesCount(int count)
    {
        numericUpDownCount.Text = count.ToString();
    }

    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        this.SendToBack();
    }

    public void SubscribeForChanges(Action updateProductPageCallback)
    {
        _updateProductPageCallback = updateProductPageCallback;
    }

    private void ButtonEdit_Click(object sender, EventArgs e)
    {
        Product product = new Product(
            productId,
            textBoxName.Text,
            textBoxCountry.Text,
            (Category)comboBoxCategory.SelectedIndex,
            Convert.ToDecimal(textBoxPrice.Text),
            DatabaseImageConverter.ImageToByteArray(pictureBox1.Image),
            richTextBoxDescription.Text,
            (Season)comboBoxSeason.SelectedIndex);

        if (Mode == ProductControlMode.Edit)
        {
            _productsRepository.UpdateProduct(product);
            sizesControl.SaveChangedToDatabase();
        }
        else if (Mode == ProductControlMode.Add)
        {
            int addedProductId = _productsRepository.AddNewProduct(product);
            sizesControl.AddNewWarehouseToDatabase(addedProductId);
        }

        // Содержит ссылку на метод из главной формы
        // Перезагрузка товаров из главной формы
        _updateProductPageCallback?.Invoke();
        this.SendToBack();
    }

    private void NumericUpDownCount_ValueChanged(object sender, EventArgs e)
    {
        int count = Convert.ToInt32(numericUpDownCount.Value);
        sizesControl.SetCountForSelectedSize(count);
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
        OpenFileDialog openFileDialog = new();

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            try
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
            catch
            {
                throw;
            }
        }
    }
}