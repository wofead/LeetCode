namespace LeetCode.Code
{
    public static  class LongestPalindrome
    {
        public static string Resolve(string str)
        {
            var len = str.Length;
            int start = 0, end = 0;
            int l = 1, r = 1;
            for (int i = 1; i < len; i++)
            {
                l = r = i;
                if (str[l-1] == str[i])
                {
                    l = l - 1;
                }else if (r + 1 < len && str[r + 1] == str[i])
                {
                    r = r + 1;
                }
                // whi
            }
            return "";
        }
    }
}