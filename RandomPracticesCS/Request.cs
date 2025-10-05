using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPracticesCS
{
    internal class Request
    {
        public static void YesOrNo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nERROR: you must say Yes (Y) or No (N)");
            Console.ResetColor();
        }

        public static void Color()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.ResetColor();
        }

        public static void NaN()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nERROR: You wrote a wrong digit, has to be a number. Try it again.");
            Console.ResetColor();
        }

        public static bool TryAgain(string projectName)
        {
            string final;

            Console.WriteLine($"\nDo you wanna try again the {projectName}?\nYes (Y) - No (N)");
            final = Console.ReadLine().ToLower();
            while (final != "yes" && final != "y" && final != "no" && final != "n")
            {
                Request.YesOrNo();
                final = Console.ReadLine().ToLower();
            }

            return (final == "yes" || final == "y");
        }
    }
}
