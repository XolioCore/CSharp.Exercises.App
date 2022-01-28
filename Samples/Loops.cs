using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exercises.App.Samples
{
    public static class Loops
    {
        public static void Run()
        {
            Fibonacci(10);
        }

        /// <summary>
        /// The Fibonacci numbers are the numbers in the following integer sequence.
        /// </summary>
        /// <param name="limit"></param>
        /// <example>0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144</example>
        public static void Fibonacci(int limit)
        {
            int a = 0;
            int b = 1;
            int aux = 0;

            Console.WriteLine(a);

            for (int i = 0; i < limit; i++)
            {
                aux = a;
                a = b;
                b = aux+b;

                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
