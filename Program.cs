using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGreeting();
            DisplayLogo();

            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nHello, {userName}! Welcome to the Cybersecurity Awareness Bot!");
            Console.ResetColor();

            Console.WriteLine("=====================================\n");

            ChatBot bot = new ChatBot();

            while (true)
            {
                Console.Write("Ask me a question (type 'exit' to quit): ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please enter a valid question.\n");
                    Console.ResetColor();
                    continue;
                }

                if (input.ToLower() == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nThank you for using the Cybersecurity Awareness Bot. Stay safe!");
                    Console.ResetColor();
                    break;
                }

                string response = bot.GetResponse(input);

                Console.ForegroundColor = ConsoleColor.Magenta;
                foreach (char c in response)
                {
                    Console.Write(c);
                    Thread.Sleep(30);
                }
                Console.WriteLine("\n");
                Console.ResetColor();
            }
        }

        static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
        }

        static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
   /$$$$$$$                      /$$
  | $$__  $$                    | $$
  | $$  \ $$  /$$$$$$  /$$   /$$| $$$$$$$
  | $$$$$$$/ /$$__  $$| $$  | $$| $$__  $$
  | $$__  $$| $$$$$$$$| $$  | $$| $$  \ $$
  | $$  \ $$| $$_____/| $$  | $$| $$  | $$
  | $$  | $$|  $$$$$$$|  $$$$$$$| $$$$$$$/
  |__/  |__/ \_______/ \____  $$|_______/
                       /$$  | $$
                      |  $$$$$$/
                       \______/
            ");
            Console.ResetColor();
            Console.WriteLine("=====================================\n");
        }
    }
}