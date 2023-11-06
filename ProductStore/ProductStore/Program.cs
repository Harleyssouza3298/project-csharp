using ProductStore.Entities;

namespace ProductStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------");

            List<Product> product = new List<Product>();

            for (int i = 0; i < numberProducts; i++)
            {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (typeProduct == 'c')
                {
                    product.Add(new Product(name, price));
                }
                else if (typeProduct == 'i')
                {
                    Console.Write("Custom fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    product.Add(new ImportedProduct(name, price, fee));
                }
                else if (typeProduct == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufatureDate = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufatureDate));

                }
                Console.WriteLine();

            }

            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Price TAGS:");

            foreach (Product products in product)
            {
                Console.Write(products.PriceTag());
            }
        }
    }
}