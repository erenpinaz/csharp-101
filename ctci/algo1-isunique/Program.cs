namespace algo1_isunique;
class Program
{
    static void Main(string[] args)
    {
        // Is string contains only ASCII characters? What should be the charset size (ex. 128, 256)?
        // Is it possible to use additional data structures (ex. HashMap)?
        // Are we allowed to modify the input string (ex. Sorting)?

        string testStr = "abcdef";
        Console.WriteLine(IsUnique(testStr)); // True

        testStr = "abcdefghijkld";
        Console.WriteLine(IsUnique(testStr)); // False

        testStr = "abb";
        Console.WriteLine(IsUnique(testStr)); // False

        testStr = "a";
        Console.WriteLine(IsUnique(testStr)); // True
    }

    private static bool IsUnique(string input)
    {
        // O(1) space
        bool[] charSet = new bool[128];

        // O(n) time
        foreach(char c in input)
        {
            if(charSet[c])
                return false;
            
            charSet[c] = true;
        }

        // O(n) time, O(1) space
        return true;
    }
}
