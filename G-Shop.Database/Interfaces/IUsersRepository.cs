namespace G_Shop.Database.Interfaces;
public interface IUsersRepository
{
    bool CheckLoginAndPassword(string text1, string text2);
}