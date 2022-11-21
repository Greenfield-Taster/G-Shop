using G_Shop.Application.Helpers;
using G_Shop.Application.Pages;
using G_Shop.Database.Repositories;
using G_Shop.Domain.Customers;
using G_Shop.Domain.Products;
using G_Shop.Domain.Sales;
using G_Shop.Domain.Users;

namespace G_Shop.Application.Controls;

public partial class ProductControl : UserControl
{
    private readonly OperationsRepository _operationsRepository = new();

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
        labelPrice.Text = selectedProduct.Price.ToString();
        labelSeason.Text = selectedProduct.Season.ToString();
        labelDescription.Text = selectedProduct.Description;
        sizesControl1.DisplaySizes(selectedProduct.Id, UpdateSizesCount);
    }

    private void UpdateSizesCount(int count)
    {
        labelCount.Text = count.ToString();
    }

    private void UpdateCountForSelectedSizeToDatabase()
    {
        int countSize = sizesControl1.GetCurrentSizeCount();
        if (numericUpDown1.Value > countSize)
        {
            return;
        }

        int changedCount =  countSize - Convert.ToInt32(numericUpDown1.Value);
        sizesControl1.SetCountForSelectedSize(changedCount);
        sizesControl1.SaveChangedToDatabase();
        
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