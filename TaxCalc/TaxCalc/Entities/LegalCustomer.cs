namespace TaxCalc.Entities
{
    internal class LegalCustomer : Customer
    {

        public int NumberEmployee { get; set; }

        double fee = 0.0;

        public LegalCustomer(string name, double balance,  int numberEmployee)
            : base(name, balance)
        {
            NumberEmployee = numberEmployee;
        }



        public override double Fee()
        {
            if (NumberEmployee > 10)
            {
                fee += Balance * 0.14;
            }
            else
            {
                fee += Balance * 0.16;
            }
            return fee;
        }
    }
}
