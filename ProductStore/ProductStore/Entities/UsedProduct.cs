using System.Text;

namespace ProductStore.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (used) ");
            sb.Append(Price.ToString("C2"));
            sb.Append(" Manufacture date (DD/MM/YYYY): ");
            sb.Append(ManufactureDate.ToString("dd/MM/yyyy"));

            return sb.ToString();
        }
    }
}
