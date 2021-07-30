namespace LeetCode.Code
{
    public static class MergerSort
    {
        public static void resolve(int[] arr)
        {
            sort(arr, 0, arr.Length - 1);
        }

        public static void sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            if (right - left == 1)
            {
                if (arr[right] < arr[left])
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }

                return;
            }

            int mid = (left + right) / 2;
            sort(arr, left, mid);
            sort(arr, mid + 1, right);
            merge(arr, left, right, mid);
        }

        public static void merge(int[] arr, int left, int right, int mid)
        {
            var len = right - left + 1;
            var originLst = left;
            var tempArr = new int[len];
            
            for (int i = 0; i < len; i++)
            {
                if (mid + 1 <= right && left <= mid)
                {
                    if (arr[left] < arr[mid + 1])
                    {
                        tempArr[i] = arr[left];
                        left++;
                    }
                    else
                    {
                        tempArr[i] = arr[mid + 1];
                        mid++;
                    }
                    continue;
                }

                tempArr[i] = mid + 1 < right ? arr[1 + mid++] : arr[left++];
            }

            for (int i = 0; i < len; i++)
            {
                arr[originLst + i] = tempArr[i];
            }
        }
    }
}