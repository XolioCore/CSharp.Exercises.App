using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exercises.App.Samples
{
    public static class Numbers
    {

        public static void MathRound()
        {
            //Even numbers round to nearest down
            Console.WriteLine(Math.Round(6.5));
            //Odd numbers round to nearest up
            Console.WriteLine(Math.Round(13.5));

        }
    }
}
