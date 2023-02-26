namespace algo11_kthtolast;
class Program
{
    static void Main(string[] args)
    {
        // Is list size known?
        // Will k be 0 < k <= len(list)?
        // Should try recursive (after iterative) with pass by reference?

        LinkedList ll = new LinkedList(new int[] { 1, 2, 3, 3, 4, 5, 1, 5, 6 });

        Node? node = ll.GetKthLast(4); // 5
        Console.WriteLine(node?.Val);

        Node? nodeR = ll.GetKthLastRec(4); // 5
        Console.WriteLine(nodeR?.Val);
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

    public Node? GetKthLast(int k)
    {
        // O(1) space
        Node? p1 = this.Head;
        Node? p2 = this.Head;

        // O(k) time
        for (int i = 0; i < k; i++)
        {
            if (p1 == null)
                return null;

            p1 = p1.Next;
        }

        // O(n) time
        while (p1 != null)
        {
            p2 = p2!.Next;
            p1 = p1.Next;
        }

        // O(n) time, O(1) space
        return p2;
    }

    public Node? GetKthLastRec(int k)
    {
        int counter = 0;

        // O(n) time, O(n) space
        return GetKthLastRec(this.Head, 4, ref counter);
    }

    private Node? GetKthLastRec(Node? head, int k, ref int counter)
    {
        if (head == null)
            return null;

        Node? node = GetKthLastRec(head.Next, k, ref counter);
        counter += 1;
        if (counter == k)
        {
            return head;
        }
        return node;
    }
}