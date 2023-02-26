namespace DataStructures.Model
{
    public class Node
    {
        public int Val { get; set; }
        public Node? Next { get; set; }

        public Node(int val)
        {
            this.Val = val;
            this.Next = null;
        }
    }
}