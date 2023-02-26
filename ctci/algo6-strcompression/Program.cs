using System.Text;

namespace algo6_strcompression;
class Program
{
    static void Main(string[] args)
    {
        string testStr = "aabcccccaaa";
        Console.WriteLine(Compress(testStr)); // a2b1c5a3

        testStr = "abcdefgg";
        Console.WriteLine(Compress(testStr)); // abcdefgg
    }

    private static string Compress(string input)
    {
        // O(n) space
        StringBuilder sb = new StringBuilder();
        int charCount = 0;

        // O(n) time
        for (int i = 0; i < input.Length; i++)
        {
            charCount++;
            if (i == input.Length - 1 || input[i + 1] != input[i])
            {
                sb.Append($"{input[i]}{charCount}");
                charCount = 0;
            }
        }

        return sb.Length < input.Length ? sb.ToString() : input;
    }
}
