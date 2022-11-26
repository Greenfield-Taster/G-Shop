using G_Shop.Database.Interfaces;

namespace G_Shop.Database.DatabaseRepositories;

internal class UsersRepository : IUsersRepository
{
    public bool CheckLoginAndPassword(string login, string password)
    {
        return true;
    }
}