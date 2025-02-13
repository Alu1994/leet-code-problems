namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    public static int LengthOfLastWord(string word)
    {
        var finalWord = "";
        bool endWord = false;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != ' ')
            {
                if (endWord) finalWord = "";

                finalWord += word[i];
                endWord = false;
                continue;
            }
            endWord = true;
        }

        return finalWord.Length;
    }

    public static int LengthOfLastWord_2(string word)
    {
        var finalWord = "";
        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (word[i] != ' ') finalWord += word[i];
            else if (finalWord.Length > 0) return finalWord.Length;
        }
        return finalWord.Length;
    }
}
