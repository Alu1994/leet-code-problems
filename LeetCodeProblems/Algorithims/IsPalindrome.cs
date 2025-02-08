//Console.WriteLine("Hello, World!");

//var r = Solution.IsPalindrome(101232101);

//Console.WriteLine(r);

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    // My Solution
    public static bool IsPalindrome(int x)
    {
        string stringVal = x.ToString();
        char[] valChar = stringVal.ToCharArray();
        for (int indexStart = 0, indexEnd = valChar.Length - 1; indexStart <= (valChar.Length / 2); indexStart++, indexEnd--)
        {
            if (valChar[indexStart] != valChar[indexEnd]) return false;
        }
        return true;
    }
}
