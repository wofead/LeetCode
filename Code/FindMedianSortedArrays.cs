using System;

namespace LeetCode.Code
{
    public static class FindMedianSortedArrays
    {
        public static int resolve(int[] arr1, int[] arr2)
        {
            var m = arr1.Length;
            var n = arr2.Length;
            int k = (m + n) % 2 == 0 ? (m + n) / 2 : (m + n + 1) / 2;
            var index1 = 0;
            var index2 = 0;
            int res = 0;
            while (k != 0)
            {
                if (index1 < m && index2 < n)
                {
                    res = (arr1[index1] > arr2[index2]) ? arr2[index2++] : arr1[index1++];
                }
                else if (index1 < m)
                {
                    res = arr1[index1++];
                }
                else
                {
                    res = arr2[index2++];
                }

                k--;
            }

            return res;
        }
    }
}