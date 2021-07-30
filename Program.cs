using System;
using LeetCode.Code;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 2, 5, 3, 0, 2, 3, 0, 3 };
            int[] arr2 = {4, 5, };

            MergerSort.resolve(arr1);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine((arr1[i]));
            }
        }
    }
}