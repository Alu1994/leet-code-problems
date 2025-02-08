//var r = Solution.RemoveDuplicates([1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4]);
//var r = Solution.RemoveDuplicates([1, 1, 2]);
//var r = Solution.RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
//Console.WriteLine(r);

namespace Algorithims;

public static partial class Solution
{
    // My Solution
    public static int RemoveDuplicates(int[] nums)
    {
        HashSet<int> result = [];
        int writeIndex = 0;
        for (int index = 0; index < nums.Length; index++)
        {
            if (result.Contains(nums[index])) continue;
            result.Add(nums[index]);
            nums[writeIndex++] = nums[index];
        }
        return writeIndex;
    }

    public static int RemoveDuplicates_2(int[] nums)
    {
        int numLength = nums.Length;

        if (numLength == 1 || (numLength == 2 && nums[0] == nums[1])) return 1;
        if (numLength == 2 && nums[0] != nums[1]) return 2;

        int compareIndex = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] >= nums[compareIndex] && nums[i] > nums[compareIndex - 1])
            {
                nums[compareIndex] = nums[i];
                compareIndex++;
            }
        }

        return compareIndex;
    }

    // Smart way without using a HashSet<int>, that takes its time to create the object to start using.
    // It initializes the (i) variable as 1 because the first value is always valid.
    // It also starts the (current) variable as 1 since we can only start re-alocating things from the 1st index onwards.
    public static int RemoveDuplicates_3(int[] nums)
    {
        if (nums is null) return 0;
        int current = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] == nums[i]) continue;            
            nums[current++] = nums[i];            
        }
        return current;
    }
}