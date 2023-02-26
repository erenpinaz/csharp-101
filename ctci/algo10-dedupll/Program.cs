namespace algo10_dedupll;
class Program
{
    static void Main(string[] args)
    {
        LinkedList ll = new LinkedList(new int[] { 1, 2, 3, 3, 4, 5, 1, 5, 6 });
        ll.Print();
        Console.WriteLine();

        // O(n) time, O(n) space
        ll.DeleteDupes();

        ll.Print();
        Console.WriteLine();
    }
}

internal class Node
{
    public int Val { get; set; }
    public Node? Next { get; set; }

    public Node(int val)
    {
        this.Val = val;
        this.Next = null;
    }
}

internal class LinkedList
{
    public Node? Head { get; set; }

    public LinkedList(int[] arr)
    {
        this.Head = Build(arr);
    }

    private Node? Build(int[] data)
    {
        Node head = new Node(data[0]);
        Node node = head;

        for (int i = 1; i < data.Length; i++)
        {
            node.Next = new Node(data[i]);
            node = node.Next;
        }

        return head;
    }

    public void Print()
    {
        Node? node = this.Head;

        while (node != null)
        {
            Console.Write($"{node.Val}{(node.Next != null ? " -> " : string.Empty)}");
            node = node.Next;
        }
    }

    public void DeleteDupes()
    {
        HashSet<int> set = new HashSet<int>();
        Node? curr = this.Head;
        Node? prev = null;

        while (curr != null)
        {
            if (set.Contains(curr.Val))
            {
                prev!.Next = curr.Next;
            }
            else
            {
                set.Add(curr.Val);
                prev = curr;
            }
            curr = curr.Next;
        }
    }
}