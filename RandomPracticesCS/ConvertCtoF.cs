using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPracticesCS
{
    internal class ConvertCtoF
    {
        public void Convertor()
        {
            do
            {
                Console.WriteLine("\nWhat do you want to convert?\n1. ºC to ºF   -   2. ºF to ºC");
                int choice;
                double fahrenheit, celsius;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice >= 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID ERROR: You have to choose a number:\n1. ºC to ºF   -   2. ºF to ºC");
                    Console.ResetColor();
                }

                if (choice == 1)
                {
                    Console.WriteLine("\nYOU SELECTED ºC to ºF.");
                    Console.WriteLine("Enter the ºC");
                    while (!double.TryParse(Console.ReadLine(), out celsius))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: You have to enter a number.");
                        Console.ResetColor();
                    }
                    fahrenheit = (celsius * 1.8) + 32;
                    Console.WriteLine($"{celsius}ºC are {Math.Round(fahrenheit, 2)}ºF");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\nYOU SELECTED ºF to ºC.");
                    Console.WriteLine("Enter the ºF");
                    while (!double.TryParse(Console.ReadLine(), out fahrenheit))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: You have to enter a number.");
                        Console.ResetColor();
                    }
                    celsius = (fahrenheit - 32) / 1.8;
                    Console.WriteLine($"{fahrenheit}ºF are {Math.Round(celsius, 2)}ºC");
                }
            } while (Request.TryAgain("Convert ºC <--> ºF"));
        }
    }
}
