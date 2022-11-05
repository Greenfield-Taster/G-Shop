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
    }
}