using DataStructures.Model;

namespace DataStructures;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        // Linked list
        LinkedList ll = new LinkedList(arr);

        // Print
        // O(n) time
        // O(1) space
        ll.Print();
        Console.WriteLine();






        // Balanced* binary tree builder
        BinaryTree bt = new BinaryTree(arr);

        // BF Traversal
        // O(n) time
        // O(w) space | w: width => 5
        bt.PrintLevelOrder();
        Console.WriteLine();

        // DF Traversal
        // O(n) time
        // O(h) space | h: height => 3
        bt.PrintPreorder();
        Console.WriteLine();

        bt.PrintInorder();
        Console.WriteLine();

        bt.PrintPostorder();
        Console.WriteLine();
    }
}