namespace G_Shop.Domain.Users;

public class User
{
    public User(int id, string name, string surname, string patronymic, Position position, string phone, string address, string login, string password)
    {
        Id = id;
        Surname = surname;
        Name = name;
        Patronymic = patronymic;
        Position = position;
        Phone = phone;
        Address = address;
        Login = login;
        Password = password;
    }

    public int Id { get; private set; }
    public string Surname { get; private set; }
    public string Name { get; private set; }
    public string Patronymic { get; private set; }
    public Position Position { get; private set; }
    public string Phone { get; private set; }
    public string Address { get; private set; }
    public string Login { get; private set; }
    public string Password { get; private set; }
}