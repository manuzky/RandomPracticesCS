using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPracticesCS
{
    internal class Fibonacci
    {
        public void NumFibo()
        {
            do
            {
                Console.WriteLine("Enter the how many times you want to see the Fibonacci Secuence:");
                int n;

                while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
                {
                    Request.NaN();
                    Console.WriteLine($"Number has to be avobe zero (0).");
                }
                Console.WriteLine("");
                int a = 0, b = 1, c;

                for (int i = 0; i < n; i++)
                {
                    c = a + b;
                    Console.WriteLine($"{a} + {b} = {c}");
                    a = b;
                    b = c;
                }
            } while (Request.TryAgain("Fibonacci Sequence"));
        }
    }
}
