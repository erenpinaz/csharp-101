namespace algo67_robotingrid;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static List<Point>? GetPath(bool[][] grid)
    {
        if (grid == null || grid.Length == 0)
            return null;

        List<Point> path = new List<Point>();
        HashSet<Point> failedPoints = new HashSet<Point>();

        // O(rc) time, O(n) space
        if (GetPath(grid, grid.Length - 1, grid[0].Length - 1, path, failedPoints))
            return path;
        else
            return null;
    }

    static bool GetPath(bool[][] grid, int row, int col, List<Point> path, HashSet<Point> failedPoints)
    {
        if (row < 0 || col < 0 || !grid[row][col])
            return false;

        bool isAtOrigin = row == 0 && col == 0;

        Point p = new Point(row, col);

        if (failedPoints.Contains(p))
        {
            return false;
        }

        if (isAtOrigin || GetPath(grid, row - 1, col, path, failedPoints) || GetPath(grid, row, col - 1, path, failedPoints))
        {
            path.Add(p);
            return true;
        }

        failedPoints.Add(p);

        return false;
    }
}

public class Point
{
    public int row;
    public int col;

    public Point(int row, int col)
    {
        this.row = row;
        this.col = col;
    }
}