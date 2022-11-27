namespace G_Shop.Domain.Warehouses;

public class Warehouse
{
    internal Warehouse()
    {
    }

    public Warehouse(int productId, int xs, int s, int m, int l, int xl, int xxl, int xxxl)
    {
        ProductId = productId;
        XS = xs;
        S = s;
        M = m;
        L = l;
        XL = xl;
        XXL = xxl;
        XXXL = xxxl;
    }

    public int ProductId { get; set; }

    public int XS { get; set; }

    public int S { get; set; }

    public int M { get; set; }

    public int L { get; set; }

    public int XL { get; set; }

    public int XXL { get; set; }

    public int XXXL { get; set; }
}