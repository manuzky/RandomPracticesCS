using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPracticesCS
{
    internal class GuessTheNumber
    {
        public void Guess()
        {
            do
            {
                Console.WriteLine("\nLet's play a guessing game! You have two options:\n1. Guess a number between 0 and 100\n2. Choose your own range of numbers");
                
                int election;

                do
                {
                    while (!int.TryParse(Console.ReadLine(), out election)) Request.NaN();

                    if (election < 1 || election > 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\nINVALID OPTION. Your options are:\n1. Guess a number between 0 and 100\n2. Choose your own range of numbers.");
                        Console.ResetColor();
                    }

                } while (election != 1 && election != 2);


                switch (election)
                {
                    case 1:
                        Option1();
                        break;
                    case 2:
                        Option2();
                        break;
                }
            } while (Request.TryAgain("Guess the Number"));
        }

        // -------------------------------------------------------------------------------------------------------------

        public void Option1()
        {
            Random rnd = new Random();
            int numRandom = rnd.Next(0, 100);
            int input, tries = 1;

            do
            {
                Console.WriteLine("I JUST SELECTED MY NUMBER, TRY TO GUESS IT!\nChoose a number");
                while (!int.TryParse(Console.ReadLine(), out input)) Request.NaN();


                if (input < 0 || input > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR. The number has to be between 0 and 100.");
                    Console.ResetColor();
                }
                else if (input < numRandom)
                {
                    Console.WriteLine("The number must be higher.");
                    tries++;
                }
                else if (input > numRandom)
                {
                    Console.WriteLine("The number must be lower.");
                    tries++;
                }

            } while (input != numRandom);

            if (tries == 1) Console.WriteLine($"\nINCREDIBLE! YOU HAVE FINISHED THE GAME IN ONLY {tries} TRIES. YOU ARE THE BEST!!");
            else if (tries <= 5) Console.WriteLine($"\nCONGRATULATIONS! you have finished the game in {tries} tries, that's amazing!");
            else Console.WriteLine($"\nCONGRATULATIONS! You have completed the game in {tries} tries... but it can be better!");

        }

        // -------------------------------------------------------------------------------------------------------------

        public void Option2()
        {
            Random rnd = new Random();
            int input, tries = 1;
            int n1, n2;

            do
            {
                Console.WriteLine("\nWhat is your range of numbers?\nSelect the first number (it has to be lower that the next one).");
                while (!int.TryParse(Console.ReadLine(), out n1)) Request.NaN();
                Console.WriteLine("Select the second number.");
                while (!int.TryParse(Console.ReadLine(), out n2)) Request.NaN();

                if (n1 > n2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ERROR. The first number has to be LOWER than the second one.");
                    Console.ResetColor();
                } 
                else if (n1 == n2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"ERROR: The numbers has to be different.");
                    Console.ResetColor();
                }
            } while (n1 > n2);

            int numRandom = rnd.Next(n1, n2);

            Console.WriteLine("\nNICE. LET'S START!");
            do
            {
                Console.WriteLine("\nChoose a number");
                while (!int.TryParse(Console.ReadLine(), out input)) Request.NaN();


                if (input < n1 || input > n2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"REMEMBER. The number has to be between {n1} and {n2}.");
                    Console.ResetColor();
                }
                else if (input < numRandom)
                {
                    Console.WriteLine("The number must be higher.");
                    tries++;
                }
                else if (input > numRandom)
                {
                    Console.WriteLine("The number must be lower.");
                    tries++;
                }

            } while (input != numRandom);

            if (tries == 1) Console.WriteLine($"\nINCREDIBLE! YOU HAVE FINISHED THE GAME IN ONLY {tries} TRIES. YOU ARE THE BEST!!");
            else if (tries <= 5) Console.WriteLine($"\nCONGRATULATIONS! you have finished the game in {tries} tries, that's amazing!");
            else Console.WriteLine($"\nCONGRATULATIONS! You have completed the game in {tries} tries... but it can be better!");

        }
    }
}
