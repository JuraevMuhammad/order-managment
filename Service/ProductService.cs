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

    public Customers FindCustomer(string searchTerm)
    {
        var res = _customers.Find(x => x.FirstName.ToLower().StartsWith(searchTerm.ToLower()) 
                                       || x.LastName.ToLower().StartsWith(searchTerm.ToLower()));
        return res;
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

    public void AddCustomer(Customers customer)
    { }
}
