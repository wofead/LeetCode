using System;

namespace LeetCode.Code
{
    public static class PopSort
    {
        /// <summary>
        /// 冒泡排序，不断的把最大的值放到最后
        /// 优化1 没有发生位置的变化就结束排序
        /// 优化2 从最后一个swap的地方接着排
        /// </summary>
        /// <param name="arr"></param>
        public static void resolve(int[] arr)
        {
            int length = arr.Length;
            var swapFlag = false;
            for (int i = 0; i < length;)
            {
                int lastStep = -1;
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        swapFlag = true;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        lastStep = j;
                    }
                }
                if (!swapFlag)
                {
                    return;
                }

                i = length - lastStep -1;
            }
        }
    }
}