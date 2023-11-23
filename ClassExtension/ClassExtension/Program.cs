using ClassExtension.Extensions;
using System.Data;

namespace ClassExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 11, 23, 8, 10, 45);

            Console.WriteLine("----------DateTime Extension-------------------");
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();
            Console.WriteLine("----------String Extension-------------------");
      
            string s1 = "Good morning dear students!";

            Console.WriteLine("Original string: " + s1);
            Console.WriteLine("Using Extension: " + s1.Cut(10)) ;
        }
    }
}