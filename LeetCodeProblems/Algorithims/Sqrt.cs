//var r = Solution.Sqrt(5000);

//Console.WriteLine(r);

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    public static int Sqrt(int x)
    {
        if (x == 0)
            return 0;

        int left = 1;
        int right = x;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            int sqrt = x / mid;

            if (sqrt == mid)
                return mid;
            else if (sqrt < mid)
                right = mid - 1;
            else
                left = mid + 1;
        }

        return right;
    }
}