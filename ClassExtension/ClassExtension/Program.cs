using ClassExtension.Extensions;
using System.Data;

namespace ClassExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 11, 23, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}