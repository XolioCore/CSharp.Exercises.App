﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Exercises.App.Samples
{
    public static class Arrays
    {
        public static void Run()
        {
            BubleSort(new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 });
        }

        static void BubleSort(int[] arr)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            Console.WriteLine(string.Join(",",arr));
            Console.ReadKey();
        }

        /// <summary>
        /// Given an array of integers, keep a total score based on the following:
        /// 1.- Add 1 point for each even number in the array
        /// 2.- Add 3 point for each odd number in the array
        /// 3.- Add 5 points for every time you encounter an 8 in the array.
        /// </summary>
        /// <param name="my_numbers"></param>
        /// <returns></returns>
        /// <example>input: [1,2,3,4,5] output: 11</example>
        /// <example>input: [15,25,35] output: 9</example>
        /// <example>input: [8,8] output: 10</example>
        public static int find_total(int[] my_numbers)
        {
            int total = 0;

            foreach (int i in my_numbers)
            {
                if (i == 8)
                {
                    total += 5;
                }
                else
                {
                    total += ((i % 2 == 0) ? 1 : 3);
                }

            }

            return total;
        }
    }
}
