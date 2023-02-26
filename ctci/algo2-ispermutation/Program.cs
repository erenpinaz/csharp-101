namespace algo2_ispermutation;
class Program
{
    static void Main(string[] args)
    {
        // Is string contains only ASCII characters? What should be the charset size (ex. 128, 256)?
        // Should comparison be case sensitive (ex. God-dog)?
        // Is whitespace significant (ex. "god   ", "dog")?
        // Are we allowed to modify the input string (ex. Sorting)?

        string input = "cricket";
        string testStr1 = "cketric";

        Console.WriteLine(IsPermutation(input, testStr1)); // True

        string testStr2 = "tekcirc";
        Console.WriteLine(IsPermutation(input, testStr2)); // True

        string testStr3 = "crick";
        Console.WriteLine(IsPermutation(input, testStr3)); // False

        string testStr4 = "cricked";
        Console.WriteLine(IsPermutation(input, testStr4)); // False
    }

    private static bool IsPermutation(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        // O(1) space
        int[] charSet = new int[128];

        // O(s) time
        foreach(char c in s)
        {
            charSet[c]++;
        }

        // O(t) time
        foreach(char c in t)
        {
            charSet[c] -= 1;
            if(charSet[c] < 0)
            {
                return false;
            }
        }

        // O(min(s, t)) time, O(1) space
        return true;
    }
}
