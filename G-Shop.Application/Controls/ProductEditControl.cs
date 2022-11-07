using G_Shop.Application.Helpers;
using G_Shop.Database.Repositories;
using G_Shop.Domain.Products;

namespace G_Shop.Application.Controls;

public partial class ProductEditControl : UserControl
{
    private readonly ProductsRepository _productsRepository = new();
    private int productId;

    public ProductEditControl()
    {
        InitializeComponent();
        
        comboBoxCategory.Items.AddRange(Enum.GetNames<Category>());
        comboBoxSeason.Items.AddRange(Enum.GetNames<Season>());
    }

    internal void DisplayEditProductInfo(Product selectedProduct)
    {
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
        textBoxCount.Text = count.ToString();
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

        _productsRepository.UpdateProduct(product);
        this.SendToBack();    
    }
}