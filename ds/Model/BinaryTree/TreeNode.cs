namespace DataStructures.Model
{
    public class TreeNode
    {
        public int Val { get; }
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }

        public TreeNode(int val)
        {
            Val = val;
            Left = null;
            Right = null;
        }
    }
}