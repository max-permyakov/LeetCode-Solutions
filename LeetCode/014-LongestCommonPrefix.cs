//-----------------------------------------------------------------------------
// Runtime: 96ms
// Memory Usage: 24.6 MB
// Link: https://leetcode.com/submissions/detail/358762489/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            var temp = strs[0];
            int i = 0;
            string prefix = "";

            while (true)
            {
                if (i >= temp.Length)
                    break;

                char currentChar = temp[i];

                foreach (var str in strs)
                {
                    if (i >= str.Length || str[i] != currentChar)
                        return prefix;
                }

                prefix += currentChar;
                i++;
            }

            return prefix;
        }
    }
    }

