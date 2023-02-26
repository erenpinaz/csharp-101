namespace DataStructures.Model
{
    public class LinkedList
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
    }
}