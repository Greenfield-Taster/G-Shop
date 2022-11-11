using G_Shop.Application.Helpers;
using G_Shop.Database.Repositories;
using G_Shop.Domain.Products;

namespace G_Shop.Application.Controls;

public partial class ProductEditControl : UserControl
{
    private readonly ProductsRepository _productsRepository = RepositoryProvider.ProductsRepository;
    private Action? productChangedCallback = null; // Хранит в себе какой-то метод из главной формы (Перезагрузить товары)
    private int productId;

    public ProductEditControl()
    {
        InitializeComponent();
        
        comboBoxCategory.Items.AddRange(Enum.GetNames<Category>());
        comboBoxSeason.Items.AddRange(Enum.GetNames<Season>());
    }

    public ProductControlMode Mode { get; set; } = ProductControlMode.Edit;

    // Выводит информацию о продукте
    internal void DisplayEditProductInfo(Product selectedProduct, Action? onProductChangedCallback)
    {
        productChangedCallback = onProductChangedCallback;
        textBoxName.Text = selectedProduct.Name;
        comboBoxCategory.SelectedIndex = (int)selectedProduct.Category;
        textBoxPrice.Text = selectedProduct.Price.ToString();
        comboBoxSeason.SelectedIndex = (int)selectedProduct.Season;
        richTextBoxDescription.Text = selectedProduct.Description;
        sizesControl1.DisplaySizes(selectedProduct.Id, UpdateSizesCount);
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
            sizesControl1.SaveChangedToDatabase();
        }
        else if (Mode == ProductControlMode.Add)
        {
            int addedProductId= _productsRepository.AddNewProduct(product);
            sizesControl1.AddNewWarehouseToDatabase(addedProductId);
        }


        productChangedCallback?.Invoke();
        this.SendToBack(); 
    }

    private void NumericUpDownCount_ValueChanged(object sender, EventArgs e)
    {
        int count = Convert.ToInt32(numericUpDownCount.Value);
        sizesControl1.SetCountForSelectedSize(count);
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