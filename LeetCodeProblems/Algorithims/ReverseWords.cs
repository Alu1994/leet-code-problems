//var r = Solution.ReverseWords_2("Matheus Veiga");

//Console.WriteLine(r);

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    public static string ReverseWords(string word)
    {
        int startIndex = 0;
        int endIndex = 0;
        string finalWord = string.Empty;

        for (; startIndex <= word.Length; endIndex++)
        {
            if (endIndex >= word.Length || word[endIndex] == ' ')
            {
                finalWord += finalWord.Length > 0 ? " " : "";
                for (int i = endIndex-1; i >= startIndex; i--)
                {
                    finalWord += word[i];
                }
                startIndex = endIndex;
            }

            if(startIndex >= word.Length) break;
        }

        return finalWord;
    }

    public static string ReverseWords_2(string word)
    {
        int startIndex = 0;
        int endIndex = 0;
        string finalWord = string.Empty;

        for (; startIndex <= word.Length; endIndex++)
        {
            if (endIndex >= word.Length || word[endIndex] == ' ')
            {
                finalWord += " " + string.Join("", word[startIndex..endIndex].Reverse().ToArray());
                startIndex = endIndex;
            }
            if (startIndex >= word.Length) break;
        }

        return finalWord[1..];
    }
}
