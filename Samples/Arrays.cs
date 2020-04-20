using System;
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

    }
}
