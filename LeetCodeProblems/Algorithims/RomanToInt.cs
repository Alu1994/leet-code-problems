//var r = Solution.RomanToInt2("MCDXLIV");

//Console.WriteLine(r);

namespace Algorithims;

public static partial class Solution
{
    // ================ My Solution ================
    public static int RomanToInt(string s)
    {
        var fromTo = new Dictionary<string, int>()
        {
            ["I"] = 1,
            ["V"] = 5,
            ["X"] = 10,
            ["L"] = 50,
            ["C"] = 100,
            ["D"] = 500,
            ["M"] = 1000
        };
        var result = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (i is 0)
            {
                result += fromTo[s[i].ToString()]; 
                break;
            }
            else if (fromTo[s[i].ToString()] > fromTo[s[i - 1].ToString()])
            {
                result += fromTo[s[i].ToString()] - fromTo[s[i-- - 1].ToString()];
                continue;
            }
            result += fromTo[s[i].ToString()];
        }

        return result;
    }
    // ================ My Solution ================

    public static int RomanToInt_2(string s)
    {
        var result = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            var current = getNumberFrom(s[i].ToString());
            if (i is 0)
            {
                result += current;
                break;
            }
            var next = getNumberFrom(s[i - 1].ToString());
            if (current > next)
            {
                result += current - next;
                i--;
                continue;
            }
            result += current;
        }

        return result;

        static int getNumberFrom(string roman) => roman switch
        {
            "I" => 1,
            "V" => 5,
            "X" => 10,
            "L" => 50,
            "C" => 100,
            "D" => 500,
            "M" => 1000,
            _ => 0
        };
    }
}
