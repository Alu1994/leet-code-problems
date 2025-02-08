////int[] nums = [0, 1, 2, 3, 4, 5, 3, 6];
//var r = Solution.RemoveElementFinal([0, 1, 2, 3, 4, 5, 3, 6], 3);
////var r = Solution.RemoveElementFinal([0, 1, 2, 2, 3, 0, 4, 2], 2);
////var r = Solution.RemoveElementFinal([1, 1, 1, 1], 1);

////Console.WriteLine(nums[..r]);
//Console.WriteLine(r);

namespace Algorithims;

public static partial class Solution
{
    // ================ My Solution ================
    public static int RemoveElementFinal(int[] nums, int val)
    {
        int writeItems = 0;
        int removedItems = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                writeItems++;
                continue;
            }

            var next = i + 1;
            while (next < nums.Length && nums[next] == val) next++;
            if (next >= nums.Length) break;
            nums[i] = nums[next];
            nums[next] = val;
            removedItems++;
        }
        return writeItems + removedItems;
    }
    // ================ My Solution ================

    public static int RemoveElement_1(int[] nums, int val)
    {
        var writeItems = 0;
        var removedItems = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                var next = i + 1;

                while (next < nums.Length && nums[next] == val) next++;
                if (next >= nums.Length) break;

                nums[i] = nums[next];
                nums[next] = val;
                removedItems++;
                continue;
            }
            writeItems++;
        }
        return writeItems + removedItems;
    }

    public static int RemoveElement_v1_1(int[] nums, int val)
    {
        int writeIndex = 0;
        for (int readIndex = 0; readIndex < nums.Length; readIndex++)
        {
            if (nums[readIndex] != val)
            {
                nums[writeIndex] = nums[readIndex];
                writeIndex++;
            }
        }
        return writeIndex;
    }

    public static int RemoveElement_2(int[] nums, int val)
    {
        Stack<int> values = new Stack<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
            {
                i++;
                while (i < nums.Length && nums[i] == val) i++;
                if (i >= nums.Length) break;
                values.Push(nums[i]);
                continue;
            }
            values.Push(nums[i]);
        }

        return values.Count;
    }

    public static int RemoveElement_3(int[] nums, int val)
    {
        int writeIndex = 0;
        for (int readIndex = 0; readIndex < nums.Length; readIndex++)
        {
            if (nums[readIndex] != val)
            {
                nums[writeIndex] = nums[readIndex];
                writeIndex++;
            }
        }
        return writeIndex;
    }
}
