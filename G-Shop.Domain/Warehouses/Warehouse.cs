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

    public int ProductId { get; private set; }

    public int Xs { get; private set; }
    
    public int S { get; private set; }
    
    public int M { get; private set; }
    
    public int L { get; private set; }
    
    public int Xl { get; private set; }
    
    public int Xxl { get; private set; }
    
    public int Xxxl { get; private set; }
}