using System.Text;

namespace ProductStore.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee)
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(' ');
            sb.Append(Price.ToString("C2"));
            sb.Append(" Custom fee: ");
            sb.AppendLine(CustomFee.ToString("C2"));

            return sb.ToString();
        }
    }
}
