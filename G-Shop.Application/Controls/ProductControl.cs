using G_Shop.Application.Helpers;
using G_Shop.Database;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Products;
using G_Shop.Domain.Sales;

namespace G_Shop.Application.Controls;

public partial class ProductControl : UserControl
{
    private readonly IOperationsRepository _operationsRepository = RepositoryProvider.OperationsRepository;

    private int productId;

    public ProductControl()
    {
        InitializeComponent();
    }

    internal void DisplayProductInfo(Product selectedProduct)
    {
        productId = selectedProduct.Id;

        labelName.Text = selectedProduct.Name;
        pictureBox1.Image = DatabaseImageConverter.ByteArrayToImage(selectedProduct.ImageBytes);
        labelCategory.Text = selectedProduct.Category.ToString();
        labelCountry.Text = selectedProduct.Country;
        labelPrice.Text = selectedProduct.Price.ToString();
        labelSeason.Text = selectedProduct.Season.ToString();
        labelDescription.Text = selectedProduct.Description;
        sizesControl.DisplaySizes(selectedProduct.Id, UpdateSizesCount);
    }

    private void UpdateSizesCount(int count)
    {
        labelCount.Text = count.ToString();
    }

    private void UpdateCountForSelectedSizeToDatabase()
    {
        int countSize = sizesControl.GetCurrentSizeCount();
        if (numericUpDown1.Value > countSize)
        {
            return;
        }

        int changedCount = countSize - Convert.ToInt32(numericUpDown1.Value);
        sizesControl.SetCountForSelectedSize(changedCount);
        sizesControl.SaveChangedToDatabase();

    }

    private void ButtonChek_Click_1(object sender, EventArgs e)
    {
        Sale sale = new Sale(
            0,
            DateTime.Now,
            productId,
            1,
            Convert.ToInt32(numericUpDown1.Value),
            Convert.ToDecimal(labelPrice.Text),
            _operationsRepository.GetNextCheckNumber(),
            1);

        UpdateCountForSelectedSizeToDatabase();
        _operationsRepository.AddNewSale(sale);
    }
}