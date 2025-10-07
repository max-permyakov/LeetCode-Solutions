//-----------------------------------------------------------------------------
// Runtime: 64ms
// Memory Usage: 15.9 MB
// Link: https://leetcode.com/submissions/detail/351897898/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _009_PalindromeNumber
    {
        
            public bool IsPalindrome(int x)
            {
                if (x < 0) return false;
                string a = x.ToString();
                string reversed = new String(a.Reverse().ToArray());
                if (x == int.Parse(reversed)) return true;
                else return false;
            }
        

    }
}
