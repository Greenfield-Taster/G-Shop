namespace G_Shop.Application;

public partial class FormMain : Form
{
    private bool userAuthorised = false;

    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonProducts_Click(object sender, EventArgs e)
    {
        if (userAuthorised == false)
        {
            return;
        }

        productsPage1.BringToFront();
    }

    private void buttonChek_Click(object sender, EventArgs e)
    {
        if (userAuthorised == false)
        {
            return;
        }

        this.chekPage1.Refresh();

        chekPage1.BringToFront();
    }

    internal void UserLogedIn()
    {
        userAuthorised = true;
        productsPage1.BringToFront();
        buttonChek.Visible = true;
        buttonProducts.Visible = true;
    }
}