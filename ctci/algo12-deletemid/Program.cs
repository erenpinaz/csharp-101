namespace algo12_deletemid;
class Program
{
    static void Main(string[] args)
    {
        // Do we have access to this middle node?

        LinkedList ll = new LinkedList(new int[] { 1, 2, 3, 3, 4, 5, 1, 5, 6 });

        ll.Print();
        Console.WriteLine();

        Node? node = ll.GetKthNode(3);
        if (node != null)
            ll.DeleteNode(node!); // 1 -> 2 -> 3 -> 4 -> 5 -> 1 -> 5 -> 6
        else
            Console.WriteLine("No node found in given index.");

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

    public Node? GetKthNode(int k)
    {
        Node? node = this.Head;

        int i = 0;
        while (node != null)
        {
            if (i == k)
                return node;

            node = node.Next;
            i++;
        }

        return null;
    }

    public bool DeleteNode(Node node)
    {
        if (node == null || node.Next == null)
            return false;

        // O(1) time, O(1) space
        node.Val = node.Next.Val;
        node.Next = node.Next.Next;

        return true;
    }
}

