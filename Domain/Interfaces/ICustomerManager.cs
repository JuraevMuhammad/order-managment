namespace Domain.Interfaces;

public interface ICustomerManager
{
    void AddCustomer(Customers customers);
    Customers FindCustomer(string searchTerm);
}