using RentalService.Entities;
using RentalService.Service;
using System.Globalization;

namespace RentalService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime pickupDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime returnDate = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine());

            CarRental carRental = new CarRental(pickupDate, returnDate, new Vehicle(model));

            RentalServices rentalService = new RentalServices(priceHour, priceDay);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);


        }
    }
}