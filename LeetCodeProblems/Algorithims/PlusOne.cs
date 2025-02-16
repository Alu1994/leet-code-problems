namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        Stack<int> stack = [];
        var plusNext = 1;
        for (int i = digits.Length-1; i >= 0 || plusNext > 0; i--)
        {
            if (i is -1)
            {
                stack.Push(plusNext);
                break;
            }

            var currentDigit = digits[i] + plusNext;
            if (currentDigit <= 9)
            {
                stack.Push(currentDigit);
                plusNext = 0;
            }
            else if (currentDigit > 9)
            {
                stack.Push(Convert.ToInt32(currentDigit.ToString()[1].ToString()));
                plusNext = 1;
            }
        }
        return stack.ToArray();
    }


    public static int[] PlusOne_2(int[] digits)
    {
        string result = "";
        foreach (int digit in digits)
        {
            result += digit.ToString();
        }
        return (Convert.ToInt32(result) + 1).ToString().Select(x => Convert.ToInt32(x.ToString())).ToArray();
    }
}