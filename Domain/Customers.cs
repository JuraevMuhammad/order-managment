namespace Domain;

public class Customers
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    private string CustomerId { get; set; }

    public string _customerId
    {
        get => CustomerId;
        set
        {
            if (int.TryParse(value, out int result))
            {
                _customerId = result.ToString("D4");
            }
            else
            {
                throw new Exception("Invalid Customer ID");
            }
        }
    }

    private int cnt = 0;
    private string count = "0000";
    public Customers(string firstName, string lastName, string address)
    {
        cnt++;
        string res = count.Remove(count.Length - cnt.ToString().Length);
        string newRes = res.Insert(res.Length, cnt.ToString());
        CustomerId = newRes;
        
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }
    
    public Customers(string firstName, string address)
    {
        cnt++;
        string res = count.Remove(count.Length - cnt.ToString().Length);
        string newRes = res.Insert(res.Length, cnt.ToString());
        CustomerId = newRes;
        
        FirstName = firstName;
        Address = address;
    }

    public Customers()
    {
        cnt++;
        string res = count.Remove(count.Length - cnt.ToString().Length);
        string newRes = res.Insert(res.Length, cnt.ToString());
        CustomerId = newRes;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Address: {Address}");
    }
}