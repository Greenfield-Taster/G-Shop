using G_Shop.Domain.Users;

namespace G_Shop.Database.Repositories;

public class UsersRepository
{
    private readonly List<User> dataBaseUsers = new()
    { 
        new User(1, "UserName","UserSurname", "UserPatronymic",Position.Сashier,"UserPhone","Address","user1","1111"),
        new User(1, "UserName2","UserSurname2", "UserPatronymic2",Position.Manager,"UserPhone2","Address2","user2","2222")
    };

    public bool CheckLoginAndPassword(string login, string password)
    {
        User? foundUser = dataBaseUsers.Find(user => user.Login == login && user.Password == password);

        if (foundUser is null)
        {
            return false;
        }

        return true;
    }
}
