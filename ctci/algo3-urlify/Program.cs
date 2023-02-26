namespace algo3_urlify;
class Program
{
    static void Main(string[] args)
    {
        // Should this problem solved in-place (C# strings are immutable)?
        // Should there always be enough space after actual string?

        string input = "Mr John Smith    ";
        int actualLength = 13;

        Console.WriteLine(Urlify(input.ToCharArray(), actualLength)); // Mr%20John%20Smith

        input = "I love C# programming language        ";
        actualLength = 30;

        Console.WriteLine(Urlify(input.ToCharArray(), actualLength)); // I%20love%20C#%20programming%20language
    }

    private static string Urlify(char[] input, int actualLength)
    {
        // O(1) space
        int idx = input.Length - 1;

        // O(n) | n: actualLength
        for(int i = actualLength - 1; i >= 0; i--)
        {
            if(input[i] == ' ')
            {
                input[idx - 2] = '%';
                input[idx - 1] = '2';
                input[idx] = '0';
                idx -= 3;
            }
            else
            {
                input[idx] = input[i];
                idx -= 1;
            }
        }

        // O(n) time, O(1) space
        return new string(input);
    }
}
