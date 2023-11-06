using System.Text;

namespace ProductStore.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" ");
            sb.AppendLine(Price.ToString("C2"));

            return sb.ToString();

        }
    }
}
