using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exercises.App.Samples
{
    public static class Strings
    {
        public static void Run()
        {
            ReverseA("Hello world");
            ReverseB("Hello world");
            //Palindrome("A Santa at Nasa");
        }


        public static void ReverseA(string input)
        {
            char[] chars = input.ToArray();
            
            string result = new string(chars.Reverse().ToArray());

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static void ReverseB(string input)
        {
            int lenght = input.Length;
            char[] chars = input.ToArray();
            char[] copy = new char[lenght];

            for (int i = 0, j = lenght - 1; i < lenght; i++, j--)
            {
                copy[j] = chars[i];
            }

            string result = new string(copy);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        /// <summary>
        /// A string that doesn't changed when reversed (it reads the same backward and forward).
        /// Examples: "eye" is a palindrome
        /// </summary>
        /// <param name="input"></param>
        public static void Palindrome(string input)
        {
            bool isPalindrome = true;
            string inputClean = input.ToLower().Replace(" ", "");
            char[] chars = inputClean.ToArray();

            for (int i = 0, j = chars.Length - 1; i < chars.Length / 2; i++, j--)
            {
                if (chars[i] != chars[j])
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine((isPalindrome?"Palindrome":"Not Palindrome"));
            Console.ReadLine();
        }


        /// <summary>
        /// How to find the first non repeated character of a given String?
        /// </summary>
        /// <param name="input"></param>
        static void NonRepeated(string input)
        {
            char[] chars = input.ToArray();
            char foundChar = ' ';

            for (int i = 0; i <= chars.Length - 1; i++)
            {
                for (int j = 0; j <= chars.Length - 1; j++)
                {
                    foundChar = chars[i];
                    if (!(i == j))
                    {
                        if (chars[i] == chars[j])
                        {
                            foundChar = ' ';
                            break;
                        }
                    }
                }

                if (!(foundChar == ' '))
                {
                    break;
                }
            }

            Console.WriteLine("nonRepeated:{0}", foundChar);

        }
    }
}
