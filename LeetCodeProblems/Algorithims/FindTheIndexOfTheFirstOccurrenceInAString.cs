//var r = Solution.StrStr("euacreditoemvoce", "em");

//Console.WriteLine(r);

namespace LeetCodeProblems.Algorithims;

// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/

/*
    28. Find the Index of the First Occurrence in a String
        Easy
        Topics
        Companies
        Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

        Example 1:

        Input: haystack = "sadbutsad", needle = "sad"
        Output: 0
        Explanation: "sad" occurs at index 0 and 6.
        The first occurrence is at index 0, so we return 0.
        Example 2:

        Input: haystack = "leetcode", needle = "leeto"
        Output: -1
        Explanation: "leeto" did not occur in "leetcode", so we return -1.
 

        Constraints:

        1 <= haystack.length, needle.length <= 104
        haystack and needle consist of only lowercase English characters.
*/

public static partial class Solution
{
    // FindTheIndexOfTheFirstOccurrenceInAString
    public static int StrStr(string haystack, string needle)
    {
        if (haystack.Length == needle.Length && haystack != needle) return -1;
        else if (haystack.Length < needle.Length) return -1;
        else if (haystack == needle) return 0;

        for (int index = 0; index < haystack.Length; index++)
        {
            if ((index + needle.Length - 1) > (haystack.Length - 1)) return -1;
            var slideWindow = index + needle.Length;
            var haystackWindow = haystack[index..slideWindow];
            if (haystackWindow == needle) return index;
        }

        return -1;
    }
}