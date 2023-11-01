/*
    Read the number of orders with N items (provide by user).
    Show all data from this order
    The order date is the same of the system: DateTime.Now 
 */

using CreateOrderByClient.Entities;
using CreateOrderByClient.Entities.Enums;

namespace CreateOrderByClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birthdate MM/DD/YYYY: ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);

            //Console.WriteLine(client);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            //Console.WriteLine(order);

            Console.WriteLine("How many items to this order ? ");
            int qtdOrder = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdOrder; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int qtdProduct = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);

                OrderItem orderItem = new OrderItem(qtdProduct, productPrice, product);

                order.AddItem(orderItem);
               
            }

            Console.WriteLine("Order Summary:");
            Console.WriteLine(order);
        }
    }
}