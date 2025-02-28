namespace ConsoleApp1.Models
{
    class Client : Person
    {
        public string Iban { get; set; }
        public string Bank { get; set; }
        public string AccountType { get; set; }


        public Client(string name, int age, string address, string phoneNumber, 
            string iban, string bank, string accountType) 
            : base(name, age, address, phoneNumber)
        {
            Iban = iban;
            Bank = bank;
            AccountType = accountType;
        }

        public void PrintClient()
        {
            this.PrintPerson();
            Console.WriteLine("IBAN: " + Iban + "\nBanco: " + Bank + "\nTipo de Conta: " + AccountType);
        }
    }
}
