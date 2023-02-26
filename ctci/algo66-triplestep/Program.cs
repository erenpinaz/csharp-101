namespace algo66_triplestep;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountWays(3));
    }

    static int CountWays(int n)
    {
        int[] memo = new int[n + 1];
        Array.Fill(memo, -1);

        // O(n) time, O(n) space
        return CountWays(n, memo);
    }

    static int CountWays(int i, int[] memo)
    {
        if (i < 0) return 0;
        if (i == 0) return 1;
        if (memo[i] > -1)
            return memo[i];
        else
            return CountWays(i - 1, memo) + CountWays(i - 2, memo) + CountWays(i - 3, memo);
    }
}
