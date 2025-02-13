namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    public static int LengthOfLongestSubstring(string word)
    {
        Dictionary<char, int> words = new Dictionary<char, int>();
        int countFinalWord = 0;
        for (int i = 0; i < word.Length; i++)
        {
            if (!words.ContainsKey(word[i]))
            {
                words.Add(word[i], i);
                continue;
            }

            if (words.Count > countFinalWord) countFinalWord = words.Count;
            i = words[word[i]] + 1;
            words.Clear();
            words.Add(word[i], i);
        }

        return countFinalWord <= words.Count ? words.Count : countFinalWord;
    }

    // https://www.youtube.com/watch?v=aHwl6PMDWJ8
    public static int LengthOfLongestSubstring_1_1(string text)
    {
        if (text.Length <= 1) return text.Length;
        Dictionary<char, int> seen = [];
        int countFinalWord = 0;
        int i = 0;

        for (int j = 0; j < text.Length; j++)
        {
            char currentChar = text[j];
            if (seen.ContainsKey(currentChar))
            {
                i = Math.Max(i, seen[currentChar] + 1);
            }

            seen[currentChar] = j;
            countFinalWord = Math.Max(countFinalWord, j - i + 1);
        }

        return countFinalWord;
    }








    public static int LengthOfLongestSubstring_2(string s)
    {
        if (s.Length <= 1) return s.Length;

        Dictionary<char, int> chars = new();

        int left = 0;
        int maxLength = 1;

        for (int i = 0; i < s.Length; i++)
        {
            char add = s[i];
            chars[add] = chars.GetValueOrDefault(add, 0) + 1;

            while (chars[add] > 1)
            {
                char remove = s[left];
                chars[remove]--;
                left++;
            }

            maxLength = Math.Max(maxLength, i - left + 1);
        }

        return maxLength;
    }



    public static int LengthOfLongestSubstring_3(string s)
    {
        Dictionary<char, int> seen = new Dictionary<char, int>();
        int i = 0, res = 0;

        for (int j = 0; j < s.Length; j++)
        {
            char currentChar = s[j];
            if (seen.ContainsKey(currentChar))
            {
                i = Math.Max(i, seen[currentChar] + 1);
            }
            seen[currentChar] = j;
            res = Math.Max(res, j - i + 1);
        }

        return res;
    }
}
