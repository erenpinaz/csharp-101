namespace algo5_oneaway;
class Program
{
    static void Main(string[] args)
    {
        // Should comparison be case sensitive (ex. p ?= P)?

        string first = "pale", second = "ple";
        Console.WriteLine(IsOneEditAway(first, second)); // True

        first = "pale"; second = "bare";
        Console.WriteLine(IsOneEditAway(first, second)); // False

        first = "pale"; second = "bale";
        Console.WriteLine(IsOneEditAway(first, second)); // True

        first = "pales"; second = "pale";
        Console.WriteLine(IsOneEditAway(first, second)); // True
    }

    private static bool IsOneEditAway(string first, string second)
    {
        if (Math.Abs(first.Length - second.Length) > 1)
            return false;

        // O(1) space
        string s1 = first.Length < second.Length ? first : second;
        string s2 = first.Length < second.Length ? second : first;

        // O(1) space
        int idx1 = 0, idx2 = 0;
        bool foundDifference = false;

        // O(m) time | m: length of shorter string
        while (idx1 < s1.Length && idx2 < s2.Length)
        {
            if (s1[idx1] != s2[idx2])
            {
                if (foundDifference)
                    return false;

                foundDifference = true;

                if (s1.Length == s2.Length)
                    idx1++;
            }
            else
            {
                idx1++;
            }
            idx2++;
        }

        // O(m) time, O(1) space
        return true;
    }
}
