using G_Shop.Application.Helpers;
using G_Shop.Domain.Products;

namespace G_Shop.Application.Controls;

public partial class ProductControl : UserControl
{
    public ProductControl()
    {
        InitializeComponent();
    }

    internal void DisplayProductInfo(Product selectedProduct)
    {
        labelName.Text = selectedProduct.Name;
        pictureBox1.Image = DatabaseImageConverter.ByteArrayToImage(selectedProduct.ImageBytes);
        labelCategory.Text = selectedProduct.Category.ToString();
        labelPrice.Text = selectedProduct.Price.ToString();
        labelSeason.Text = selectedProduct.Season.ToString();
        labelDescription.Text = selectedProduct.Description;
        sizesControl1.DisplaySizes(selectedProduct.Id, UpdateSizesCount);
    }

    private void UpdateSizesCount(int count)
    {
        labelCount.Text = count.ToString();
    }
}