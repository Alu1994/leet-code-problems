//var r = Solution.SearchInsertPosition([1, 3, 5, 6], 5);
//var r = Solution.SearchInsertPosition([1, 3, 5, 6], 2);
//var r = Solution.SearchInsertPosition([1, 3, 5, 6], 7);
//var r = Solution.SearchInsertPosition([1, 3, 5, 6], 0);
//var r = Solution.SearchInsertPosition([1], 0);
//var r = Solution.SearchInsertPosition([1, 3], 3);

//var r = Solution.SearchInsertPosition([1, 5, 6, 8, 9, 10], 1);

//var r = Solution.SearchInsert([1, 3, 4, 5, 6, 7, 8, 10], 9);

//Console.WriteLine(r);

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{

    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            var currentMid = nums[mid];

            if (currentMid == target)
                return mid;
            else if (currentMid < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return left;
    }



    public static int SearchInsertPosition(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid; // Target found
            }
            else if (nums[mid] < target)
            {
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }

        return left; // If target not found, return insertion position
    }
}