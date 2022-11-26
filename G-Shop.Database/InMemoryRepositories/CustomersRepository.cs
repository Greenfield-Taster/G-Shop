using G_Shop.Database.Interfaces;
using G_Shop.Domain.Customers;

namespace G_Shop.Database.InMemoryRepositories;

internal class CustomersRepository : ICustomersRepository
{
    private readonly List<Customer> databaseCustomers = new()
    {
        new Customer(1, "Ukraine", "Запоріжжя, Миру, 2", "0687515246", "85333"),
        new Customer(2, "Polsha", "Wrotslaw, Zelenskiy, 95", "0954568741", "85444"),
        new Customer(3, "Ukraine", "Київ, Залужного, 78", "0956813456", "98745"),
    };
}