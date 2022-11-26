namespace G_Shop.Database.Interfaces;
public interface IUsersRepository
{
    bool CheckLoginAndPassword(string login, string password);
}