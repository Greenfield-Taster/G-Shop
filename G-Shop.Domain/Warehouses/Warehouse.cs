namespace G_Shop.Domain.Warehouses;

public class Warehouse
{
    public Warehouse(int productId, int xs, int s, int m, int l, int xl, int xxl, int xxxl)
    {
        ProductId = productId;
        Xs = xs;
        S = s;
        M = m;
        L = l;
        Xl = xl;
        Xxl = xxl;
        Xxxl = xxxl;
    }

    public int ProductId { get; set; }

    public int Xs { get; set; }

    public int S { get; set; }

    public int M { get; set; }

    public int L { get; set; }

    public int Xl { get; set; }

    public int Xxl { get; set; }

    public int Xxxl { get; set; }
}