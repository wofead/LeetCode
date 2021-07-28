using System.Collections.Generic;

namespace LeetCode.Code
{
    public class NoSameStrMaxLength
    {
        public static int resolve(string str)
        {
            int len = str.Length;
            if (len == 0 || len == 1)
            {
                return len;
            }

            int maxLen = 1;
            int l = -1;
            Dictionary<char, int> hash = new Dictionary<char, int>();
            hash[str[0]] = 0;
            for (int i = 1; i < len; i++)
            {
                if (hash.ContainsKey(str[i]) && hash[str[i]] > l)
                {
                    l = hash[str[i]];
                    maxLen = maxLen > i - hash[str[i]] ? maxLen : i - hash[str[i]];
                    hash.Remove(str[i]);
                }

                hash[str[i]] = i;
            }
            if (l == -1)
            {
                return len;
            }
            maxLen = maxLen > len - l -1 ? maxLen : len - l -1 ;
            return maxLen;
        }
    }
}