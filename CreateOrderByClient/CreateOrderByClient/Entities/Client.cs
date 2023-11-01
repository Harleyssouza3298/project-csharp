    namespace CreateOrderByClient.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email {  get; set; }
        public DateTime Birthdate { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthdate)
        {
            Name = name;
            Email = email;
            Birthdate = birthdate;
        }

        public override string ToString()
        {
            return "Name: " + Name +
                " Email: " + Email +
                " Birthdate: " + Birthdate;
                
        }
    }
}
