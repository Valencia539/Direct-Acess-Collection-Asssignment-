using System;

struct Product
{
    public int id;
    public string name;
    public int quantity;
    public double price;
}

class Program
{
    static Product[] products = new Product[100];
    static int counter = 0;

    static void AddProduct()
    {
        Product product = new Product();

        Console.Write("Enter Product ID: ");
        product.id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product Name: ");
        product.name = Console.ReadLine();

        Console.Write("Enter Product Quantity: ");
        product.quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Product Price: ");
        product.price = Convert.ToDouble(Console.ReadLine());

        products[counter] = product;
        counter++;
    }

    static void DisplayAll()
    {
        for (int i = 0; i < counter; i++)
        {
            Console.WriteLine($"Product ID: {products[i].id}");
            Console.WriteLine($"Product Name: {products[i].name}");
            Console.WriteLine($"Product Quantity: {products[i].quantity}");
            Console.WriteLine($"Price: {products[i].price}");
        }
    }

    static void SearchProduct(int id)
    {
        for (int i = 0; i < counter; i++)
        {
            if (products[i].id == id)
            {
                Console.WriteLine($"Product ID: {products[i].id}");
                Console.WriteLine($"Product Name: {products[i].name}");
                Console.WriteLine($"Product Quantity: {products[i].quantity}");
                Console.WriteLine($"Price: {products[i].price}");
            }
        }
    }

    static void EditProduct(int id)
    {
        for (int i = 0; i < counter; i++)
        {
            if (products[i].id == id)
            {
                Console.Write("Enter New Product Name: ");
                products[i].name = Console.ReadLine();

                Console.Write("Enter New Quantity: ");
                products[i].quantity = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Price: ");
                products[i].price = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

    static void DeleteProduct(int id)
    {
        for (int i = 0; i < counter; i++)
        {
            if (products[i].id == id)
            {
                products[i] = new Product();
                counter--;
            }
        }
    }
}
