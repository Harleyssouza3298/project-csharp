using Orders.Entities;
using Orders.Entities.Enums;

namespace Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("How many contracts to this worker ?");
            int numberContracts = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");

            for (int i = 0; i < numberContracts; i++)
            {
                Console.WriteLine($"Enter #{numberContracts + 1} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Durations (hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Enter month and year to calculate the income (MM/YYYY):");
            string monthYear = Console.ReadLine();

            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthYear + ": " + worker.Income(year, month));

        }
    }
}