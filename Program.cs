using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            Console.Write("Type your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("Type your city name: ");
            string cityName = Console.ReadLine();

            Console.Write("Results: ");


            DisplayResult(ReverseString(firstName), ReverseString(lastName),
                ReverseString(cityName));

            Console.ReadLine();
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);

        }

        private static void DisplayResult(string reversedFirstName,
            string reversedLastName, string reversedCityName)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName,
    reversedLastName, reversedCityName));
        }
        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
