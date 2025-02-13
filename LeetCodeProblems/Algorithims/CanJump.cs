//var r = Solution.CanJump([1, 1, 1, 1, 4]);

//Console.WriteLine(r);

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    public static bool CanJump(int[] nums)
    { 
        int goal = nums.Length - 1;

        for (int i = nums.Length - 2; i > -1; i--)
            if(i + nums[i] >= goal)
                goal = i;

        return goal == 0;
    }
}
