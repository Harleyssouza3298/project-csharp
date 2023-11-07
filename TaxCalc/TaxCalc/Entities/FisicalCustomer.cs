namespace TaxCalc.Entities
{
    internal class FisicalCustomer : Customer
    {
        public double HealthCare { get; set; }

        public FisicalCustomer(string name, double balance, double healthCare)
            : base(name, balance)
        {
            HealthCare = healthCare;
        }

        double amountTax = 0.0;
        public override double Fee()
        {
            if (Balance < 20000.0)
            {
                amountTax += Balance * 0.15;
            }
            else
            {
                amountTax += Balance * 0.25;
            }

            if (HealthCare > 0)
            {
                amountTax -= HealthCare * 0.5;
            }

            return amountTax;
        }
    }
}
