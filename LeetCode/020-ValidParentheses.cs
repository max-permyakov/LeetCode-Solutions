//-----------------------------------------------------------------------------
// Runtime: 68ms
// Memory Usage: 21.9 MB
// Link: https://leetcode.com/submissions/detail/358336005/
//-----------------------------------------------------------------------------

using System.Collections.Generic;

namespace LeetCode
{
    public class _020_ValidParentheses
    {

        public bool IsValid(string s)
        {
        Stack<char> stack=new Stack<char> ();
            foreach (char c in s)
            {
                if (c == '('||c=='{'||c=='[') {
                    stack.Push(c);


                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false;
                    var last = stack.Pop();
                    if((c == ')'&& last=='(' )
                    || (c == ']' && last == '[') 
                    || (c == '}' && last == '{'));
                    else return false;
                }
            }
            return stack.Count == 0;

        }
    }
}
