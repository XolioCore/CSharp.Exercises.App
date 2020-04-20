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
        }
    }
}
