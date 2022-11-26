using G_Shop.Database;
using G_Shop.Database.Interfaces;

namespace G_Shop.Application.Pages;

public partial class UserPage : UserControl
{
    private readonly IUsersRepository _usersRepository = RepositoryProvider.UsersRepository;

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
