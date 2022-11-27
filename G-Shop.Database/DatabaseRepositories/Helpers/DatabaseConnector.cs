using System.Data.SqlClient;

namespace G_Shop.Database.DatabaseRepositories.Helpers;

internal static class DatabaseConnector
{
    internal const string ConnectionString = "Data Source=ASUSROGSTRIX;Initial Catalog=G-Shop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    private static readonly SqlConnection _connection = new(ConnectionString);

    public static SqlConnection Connection => _connection;
}
