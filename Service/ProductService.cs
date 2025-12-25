using Domain;
using Domain.Interfaces;

namespace Service;

public class ProductService : ICustomerManager, IProductManager
{
    private readonly List<Products> _products = new();
    private readonly List<Customers> _customers = new();

    public void AddProduct(Products product)
    {
        _products.Add(product);
    }

    public Products FindProduct(string searchTerm)
    {
        var result = _products.Find(x => x.Name.ToLower().StartsWith(searchTerm.ToLower()));
        if (result != null) 
        {
            return result; 
        }
        else
        {
            return null;
        }
    }

    public Customers FindCustomer(string search)
    {
        string searchTerm = search.Trim().Replace(" ", "");
        var res = _customers.Find(x => x.FirstName.ToLower().StartsWith(searchTerm.ToLower()) 
                                       || x.LastName.ToLower().StartsWith(searchTerm.ToLower()));
        var res2 = _customers.Find(x => x.FirstName.ToLower().Contains(searchTerm.ToLower())
        || x.LastName.ToLower().Contains(searchTerm.ToLower()));
        if (res != null || res2 != null)
        {
            return res;
        }
        else
        {
            return null;
        }
    }

    public void DisplayProducts()
    {
        foreach (var product in _products)
        {
            product.DisplayInfo();
        }
    }

    public void DisplayCustomers()
    {
        foreach (var customer in _customers)
        {
            customer.DisplayInfo();
        }
    }

    private int cnt = 0;
    public void AddCustomer(Customers customer)
    {
        int count = 0;
        _customers.Add(customer);
        cnt++;
        if (cnt > count)
        {
            Console.WriteLine($"Покупатель {customer._customerId} успешно добавлен!");
        }

        count = cnt;
    }
}
