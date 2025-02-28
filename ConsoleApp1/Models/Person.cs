namespace ConsoleApp1.Models
{
    class Person
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string name, int age, string address, string phoneNumber)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Nome: " + Name + "\nIdade: " + Age + "\nMorada: " + Address + "\nContacto: " + PhoneNumber);
        }
    }
}
