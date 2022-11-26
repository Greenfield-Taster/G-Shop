namespace G_Shop.Database.DatabaseRepositories.Helpers;

internal static class StreamExtensions
{
    public static byte[] GetBytes(this Stream input)
    {
        using MemoryStream memoryStream = new();
        input.CopyTo(memoryStream);
        return memoryStream.ToArray();
    }
}