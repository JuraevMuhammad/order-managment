namespace Domain.Interfaces;

public interface IProductManager
{
    void AddProduct(Products products);
    void DisplayProducts();
    Products FindProduct(string searchTerm);
}