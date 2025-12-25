namespace Domain;

public class Products
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Products(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }

    public Products()
    {
        
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, Quantity: {Quantity}");
    }
}
