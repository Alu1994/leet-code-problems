//Console.WriteLine("Hello, World!");

//var r = Solution.TwoSum([0, 4, 3, 0], 0);

//Console.WriteLine(r.First());
//Console.WriteLine(r.Last());

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    // ================ My Solution ================
    public static int[] TwoSum(int[] nums, int target) 
    {
        List<KeyValuePair<int, int>> seen = [];
        for (int index = 0; index < nums.Length; index++)
        {
            int diff = target - nums[index];
            var exists = seen.Select(x => x.Key).Contains(diff);
            if (exists)
                return [seen.First(x => x.Key == diff).Value, index];
            seen.Add(new KeyValuePair<int, int>(nums[index], index));
        }
        return [0, 0];
        // ================ My Solution ================
    }
}






