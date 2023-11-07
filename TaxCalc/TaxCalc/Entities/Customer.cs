using System.Text;

namespace TaxCalc.Entities
{
    internal abstract class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }


        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
            
        }

        public abstract double Fee();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(": ");
            sb.Append(Fee().ToString("C2"));

            return sb.ToString();
        }
    }
}
