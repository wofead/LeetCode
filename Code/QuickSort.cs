namespace LeetCode.Code
{
    public static class QuickSort
    {
        public static void resolve(int[] arr)
        {
            //快速排序，主要是根据一个key，将大于key的放到右侧，小于key的放到左侧
            sort(arr, 0, arr.Length - 1);
        }

        public static void sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int originLst = left, originRight = right;
            int key = left;
            while (left < right)
            {
                while (arr[key] <= arr[right] && right > left)
                {
                    right--;
                }

                if (right > left)
                {
                    int temp = arr[key];
                    arr[key] = arr[right];
                    arr[right] = temp;
                    key = right;
                }
                while (arr[key] >= arr[left] && right > left)
                {
                    left++;
                }
                if (right > left)
                {
                    int temp = arr[key];
                    arr[key] = arr[left];
                    arr[left] = temp;
                    key = left;
                }
            }
            sort(arr, originLst, key - 1);
            sort(arr, key + 1, originRight);
        }
        
    }
}