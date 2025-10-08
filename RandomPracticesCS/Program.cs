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

            string options = "1. Convert ºC <--> ºF\n2. Fibonacci Secuence\n3. Guess the number\n0. EXIT";
            int input;
            string final;

            // CLASSES && OBJECTS
            ConvertCtoF Convertor = new ConvertCtoF();
            Fibonacci getFibo = new Fibonacci();
            GuessTheNumber Guess = new GuessTheNumber();

            do
            {
                Console.WriteLine("\nSelect (by a number) the program u want to try:\n");
                Console.WriteLine(options);

                while (!int.TryParse(Console.ReadLine(), out input) || input < 0 || input > 3)
                {
                    Request.NaN();
                    Console.WriteLine($"\nThe options are:\n\n{options}");
                }

                switch (input)
                {
                    case 1:
                        Request.Color(); Convertor.Convertor(); Request.Color();
                        break;
                    case 2:
                        Request.Color(); getFibo.NumFibo(); Request.Color();
                        break;
                    case 3:
                        Request.Color(); Guess.Guess(); Request.Color();
                        break;
                    case 0:
                        Console.WriteLine("\nI hope u enjoyed my mini-project.\nFINISHING...");
                        return;
                }

                Console.WriteLine("\nWould you like to try other mini-project?\nYes (Y) -  No (N)");
                final = Console.ReadLine().ToLower();
                while (final != "yes" && final != "y" && final != "no" && final != "n")
                {
                    Request.YesOrNo();
                    final = Console.ReadLine().ToLower();
                }
            } while (final == "yes" || final == "y");
            
            Console.WriteLine("\nI hope u enjoyed my mini-project.\nFINISHING...");
        }
    }
}