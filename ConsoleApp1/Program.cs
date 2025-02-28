using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HelloWord();
            PressAnyKeyToExit();
            int result = CalculateSomething(1, 2);

            Person person = new Person("Vinicius", 33, "Rua Fonte de Sao Romao", "913-942-008");


            Console.WriteLine("Give me a Name: ");
            string name = Console.ReadLine();

            Client client = new Client("Ximenes", 25, "Av Dom Joao", "913-942-455", "PT50 0001 0002 0003 0004 0005 6", "BPI", "Conta Corrente");

            client.PrintClient();

        }

        public static void HelloWord()
        {
            Console.WriteLine("Hello World!");
        }

        public static void PressAnyKeyToExit()
        {
            Console.WriteLine("Press any key to exit.");
        }

        public static int CalculateSomething(int valor1, int valor2)
        {
            return valor1 + valor2;
        }
    }
}
