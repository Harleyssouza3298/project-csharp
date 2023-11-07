using TaxCalc.Entities;

namespace TaxCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int numberPayers = int.Parse(Console.ReadLine());

            List<Customer> customer = new List<Customer>();

            Console.WriteLine("----------------------------");

            for (int i = 0; i < numberPayers; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or Company (i/c): ");
                char typeCustomer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());

                if(typeCustomer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthCare = double.Parse(Console.ReadLine());

                    customer.Add(new FisicalCustomer(name, income,healthCare));
                }
                else if (typeCustomer == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployee = int.Parse(Console.ReadLine());
                    customer.Add(new LegalCustomer(name, income, numberEmployee));
                }


            }

            Console.WriteLine("--------------------------------------");
            
            double totalTax = 0.0;

            foreach(Customer c in  customer)
            
            {
                totalTax += c.Fee();
                Console.WriteLine(c);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("TOTAL TAXES: " + totalTax.ToString("C2"));

        }
    }
}