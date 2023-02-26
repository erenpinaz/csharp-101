namespace algo4_palindromeperm;
class Program
{
    static void Main(string[] args)
    {
        // Can string contain only alpha characters (ex. a-z)?
        // Can string contain lower and uppercase letters (ex. a-Z)?

        string testStr = "Taco cat";
        Console.WriteLine(IsPalindromePermutation(testStr)); // True
    }

    private static bool IsPalindromePermutation(string input)
    {
        // O(1) space
        HashSet<int> hash = new HashSet<int>(26);
        int a = (int)'a' % 32; // 1
        int z = (int)'z' % 32; // 26

        // O(n) time
        foreach (char c in input)
        {
            int ic = (int)c % 32;

            if (a >= ic && ic <= z)
            {
                if (hash.Contains(ic))
                {
                    hash.Remove(ic);
                }
                else
                {
                    hash.Add(ic);
                }
            }
        }

        // O(n) time, O(1) space
        return hash.Count <= 1;
    }
}
