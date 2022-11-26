namespace G_Shop.Domain.Customers;

public class Customer
{
    public Customer(int id, string country, string address, string phone, string index)
    {
        Id = id;
        Country = country;
        Address = address;
        Phone = phone;
        Index = index;
    }

    public int Id { get; private set; }

    public string Country { get; private set; }

    public string Address { get; private set; }

    public string Phone { get; private set; }

    public string Index { get; private set; }
}