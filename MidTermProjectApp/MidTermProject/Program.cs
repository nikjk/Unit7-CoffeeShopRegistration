using MidTermProject;

static void Main(string[] args)
{
    // Initialize product list
    List<Product> products = new List<Product>()
            {
                // Add at least 12 products with name, category, description, and price
                new Product() { Name = "Product 1", Category = "Category 1", Description = "Description 1", Price = 1.99m },
                new Product() { Name = "Product 2", Category = "Category 1", Description = "Description 2", Price = 2.99m },
                new Product() { Name = "Product 3", Category = "Category 1", Description = "Description 3", Price = 3.99m },
                // ...
            };

    // Initialize order list to store items ordered
    List<Product> order = new List<Product>();

    // Initialize variables for subtotal, tax, grand total, and payment type
    decimal subtotal = 0m;
    decimal taxRate = 0.08m; // 8% sales tax
    decimal tax = 0m;
    decimal grandTotal = 0m;
    string paymentType = "";

    // Display menu and get user input
    while (true)
    {
        Console.Clear();
        Console.WriteLine("===== MENU =====");
        Console.WriteLine("No. | Name | Category | Description | Price");
        Console.WriteLine("------------------------------------------");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. | {products[i].Name} | {products[i].Category} | {products[i].Description} | {products[i].Price:C}");
        }
        Console.WriteLine("==========================================");
        Console.WriteLine("Enter item number to order or press 'Enter' to complete purchase: ");

        string input = Console.ReadLine().Trim();

        // If user presses 'Enter', complete purchase
        if (string.IsNullOrEmpty(input))
        {
            break;
        }

        // Parse user input as integer
        int itemIndex;
        if (!int.TryParse(input, out itemIndex) || itemIndex < 1 || itemIndex > products.Count)
        {
            Console.WriteLine("Invalid input! Press any key to continue...");
            Console.ReadKey();
            continue;
        }

        // Get quantity for the item ordered
        Console.WriteLine($"Enter quantity for '{products[itemIndex - 1].Name}': ");
        input = Console.ReadLine().Trim();

        // Parse quantity as integer
        int quantity;
        if (!int.TryParse(input, out quantity) || quantity < 1)
        {
            Console.WriteLine("Invalid quantity! Press any key to continue...");
            Console.ReadKey();
            continue;
        }

        // Add item to order list
        Product item = new Product()
        {
            Name = products[itemIndex - 1].Name,
            Category = products[itemIndex - 1].Category,
            Description = products[itemIndex - 1].Description,
            Price = products[itemIndex - 1].Price
        };
        order.Add(item);

        // Calculate line total and add to subtotal
        decimal lineTotal = item.Price * quantity;
        subtotal += lineTotal;
    }
}