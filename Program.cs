using System;
using LeetCode.Code;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 2, 3};
            int[] arr2 = {4, 5, };

            Console.WriteLine(FindMedianSortedArrays.resolve(arr1, arr2));
        }
    }
}