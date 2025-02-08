//var r = Solution.IsValidParentheses2("[([]{})]");

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    // ================ My Solution ================
    public static bool IsValidParentheses(string s)
    {
        if (s.Length % 2 != 0) return false;

        Dictionary<char, char> hashmap = new()
        { 
            ['['] = ']',
            ['{'] = '}',
            ['('] = ')'
        };

        for (int startIndex = 0, endIndex = s.Length - 1; startIndex < (s.Length / 2); startIndex++, endIndex--)
            if (hashmap[s[startIndex]] != s[endIndex]) return false;
        return true;
    }
    // ================ My Solution ================

    public static bool IsValidParentheses_2(string parentheses)
    {
        if (parentheses.Length % 2 != 0) return false;

        Stack<char> stack = new();
        Dictionary<char, char> dict = new()
        {
            ['['] = ']',
            ['{'] = '}',
            ['('] = ')'
        };

        for (int i = 0; i < parentheses.Length; i++)
        {
            char currentParenthesesKey = parentheses[i];
            char currentParenthesesValue = stack.Count > 0 ? dict[stack.Peek()] : ' ';

            if (dict.Keys.Contains(currentParenthesesKey))
                stack.Push(currentParenthesesKey);
            else if (stack.Count > 0 && currentParenthesesKey == currentParenthesesValue)
                stack.Pop();
            else
                return false;
        }

        return stack.Count is 0;
    }
}
