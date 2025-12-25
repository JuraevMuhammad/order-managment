
using Domain;
using Service;

ProductService productService = new ProductService();

while (true)
{
    Console.WriteLine("""
                      1. Добавить продукт
                      2. Найти продукт
                      3. Найти клиента
                      4. Отобразить все продукты
                      5. Отобразить всех клиентов
                      6. Добавить Customer
                      7. Выйти из программы
                      """);
    Console.Write("Выберите пункт: ");
    var input = int.Parse(Console.ReadLine());

    switch (input)
    {
        case 1:
            Console.WriteLine("1. Добавить продукт");
            Console.Write("Введите название продукта: ");
            string productName = Console.ReadLine();
            Console.Write("Введите цену продукта: ");
            double productPrice;
            try
            {
                productPrice = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Добавьте цену без <.> или используйте <,>");
                break;
            }
            Console.Write("Введите количество: ");
            int productQuantity = int.Parse(Console.ReadLine());
            
            productService.AddProduct(new Products(productName, productPrice, productQuantity));
            Console.WriteLine("Продукт Яблоко успешно добавлен.");
            break;
        case 2:
            Console.WriteLine("2. Найти продукт");
            Console.Write("Введите название продукта: ");
            string searchProductName = Console.ReadLine();
            
            productService.FindProduct(searchProductName);
            break;
        case 3: 
            Console.WriteLine("3. Найти клиента");
            Console.Write("Введите имя клиента для поиска: ");
            string searchCustomerName = Console.ReadLine();

            productService.FindCustomer(searchCustomerName);
            break;
        case 4:
            Console.WriteLine("4. Отобразить все продукты");
             
            productService.DisplayProducts();
            break;
        case 5:
            Console.WriteLine("5. Отобразить всех покупателей");
            
            productService.DisplayCustomers();
            break;
        case 6:
            Console.WriteLine("6. Добавить Customer");
            Console.Write("Введите имя покупателья: ");
            string fristName = Console.ReadLine();
            Console.Write("Введите фамилия покупателья (необезательно): ");
            string lastName = Console.ReadLine();
            Console.Write("Введите адресс покупателья: ");
            string address = Console.ReadLine();
            
            productService.AddCustomer(new Customers(fristName, lastName, address));
            break;
        case 7:
            return;
        default:
            Console.WriteLine("-Попробуйте ещё раз!");
            break;
    }
}