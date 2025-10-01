using System;
using System.Reflection.Emit;

namespace RandomPracticesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // WELCOME
            Console.WriteLine("Hi! This is an example of different practices I'll be doing over time. I'll be updating this program little by little as I practice.");

            string options = "1. Convert ºC <--> ºF\n0. EXIT";
            int input;
            string final;

            // CLASSES && OBJECTS
            ConvertCtoF Convertor = new ConvertCtoF();

            do
            {
                Console.WriteLine("\nSelect (by a number) the program u want to try:\n");
                Console.WriteLine(options);

                while (!int.TryParse(Console.ReadLine(), out input) || input <= -1 || input >= 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: You wrote a wrong digit. Try it again.");
                    Console.ResetColor();
                    Console.WriteLine($"\nThe options are:\n\n{options}");
                    Console.ResetColor();
                }

                switch (input)
                {
                    case 1:
                        Convertor.Convertor();
                        break;
                    case 0:
                        Console.WriteLine("\nI hope u enjoyed my mini-project.\nFINISHING...");
                        return;
                }

                Console.WriteLine("\nDo you want to execute de program again with other mini-project?\nYes (Y) -  No (N)");
                final = Console.ReadLine().ToLower();
                while (final != "yes" && final != "y" && final != "no" && final != "n")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: you must say Yes (Y) or No (N)");
                    Console.ResetColor();
                    final = Console.ReadLine().ToLower();
                }
            } while (final == "yes" || final == "y");

            Console.WriteLine("\nI hope u enjoyed my mini-project.\nFINISHING...");
        }
    }
}