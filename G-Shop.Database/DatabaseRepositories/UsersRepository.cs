using Dapper;
using G_Shop.Database.DatabaseRepositories.Helpers;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Users;
using System.Data.SqlClient;

namespace G_Shop.Database.DatabaseRepositories;

internal class UsersRepository : IUsersRepository
{
    public bool CheckLoginAndPassword(string login, string password)
    {
        return true;
        //string sql = @"SELECT * FROM Users WHERE Login = @login AND Password = @password;";
       
        //if (DatabaseConnector.Connection.Execute(sql) is null)
        //{
        //    return false;
        //}
        //    return true;
    }
}