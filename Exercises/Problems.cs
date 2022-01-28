using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exercises.App.Exercises
{
    public static class Problems
    {

        public static void Run()
        {
            CenturyFromYear(1905);
        }

        /// <summary>
        /// Given a year, return the century it is in. The first century spans from the year 1 up to and including the year 100, 
        /// the second - from the year 101 up to and including the year 200, etc.
        /// </summary>
        /// <param name="year"></param>
        /// <example>
        /// For year = 1905, the output should be solution(year) = 20; 
        /// For year = 1700, the output should be solution(year) = 17.
        /// </example>
        public static void CenturyFromYear(int year)
        {
            int century = (year % 100 > 0 ? (year / 100) + 1 : year / 100);

            Console.WriteLine(string.Join(",", century));
            Console.ReadKey();
        }

    }
}
