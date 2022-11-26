using System.Drawing.Imaging;

namespace G_Shop.Application.Helpers;

internal static class DatabaseImageConverter
{
    public static byte[] ImageToByteArray(Image imageIn)
    {
        MemoryStream ms = new MemoryStream();
        imageIn.Save(ms, ImageFormat.Gif);
        return ms.ToArray();
    }

    public static Image ByteArrayToImage(byte[] byteArrayIn)
    {
        if (byteArrayIn.Length == 0)
        {
            return Properties.Resources.empty_profile;
        }

        MemoryStream ms = new MemoryStream(byteArrayIn);        
        Image returnImage = Image.FromStream(ms);
        return returnImage;
    }
}
