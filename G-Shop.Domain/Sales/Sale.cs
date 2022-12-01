namespace G_Shop.Domain.Sales;

public class Sale
{
    public Sale(int id, DateTime dataTime, int productId, int userId, int amount, decimal price, int chekId, int customerId)
    {
        Id = id;
        DateAndTime = dataTime;
        ProductId = productId;
        UserId = userId;
        Amount = amount;
        Price = price;
        ChekId = chekId;
        CustomerId = customerId;
    }
    public int Id { get; set; }

    public DateTime DateAndTime { get; private set; }

    public int ProductId { get; private set; }

    public int UserId { get; private set; }

    public int Amount { get; private set; }

    public decimal Price { get; private set; }

    public int ChekId { get; private set; }

    public int CustomerId { get; private set; }
}