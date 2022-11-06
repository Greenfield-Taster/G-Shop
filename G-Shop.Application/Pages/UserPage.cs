using G_Shop.Database.Repositories;

namespace G_Shop.Application.Pages;

public partial class UserPage : UserControl
{
    private readonly UsersRepository _usersRepository = new();

    public UserPage()
    {
        InitializeComponent();
    }

    private void ButtonLogin_Click(object sender, EventArgs e)
    {
        bool userExists = _usersRepository.CheckLoginAndPassword(textBoxLogin.Text, textBoxPassword.Text);

        if (userExists == false) 
        {
            MessageBox.Show("Такого акаунту не існує.");
            return;
        }

        Program.MainForm.UserLogedIn();
    }
}
