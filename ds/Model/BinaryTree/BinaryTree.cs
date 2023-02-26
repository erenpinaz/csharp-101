namespace DataStructures.Model
{
    public class BinaryTree
    {
        public TreeNode? Root { get; }

        public BinaryTree(int[] data)
        {
            Root = Build(data, 0);
        }

        private TreeNode? Build(int[] data, int i)
        {
            if (i >= data.Length) return null;

            TreeNode node = new TreeNode(data[i]);
            node.Left = Build(data, 2 * i + 1);
            node.Right = Build(data, 2 * i + 2);

            return node;
        }

        public void PrintLevelOrder()
        {
            if (Root == null)
            {
                Console.WriteLine("Tree is empty!");
            }
            else
            {
                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(Root);
                while (queue.Count != 0)
                {
                    TreeNode current = queue.Dequeue();
                    Console.Write($"{current.Val} ");

                    if (current.Left != null)
                        queue.Enqueue(current.Left);

                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }
            }
        }

        public void PrintPreorder() => printPreorder(Root);

        public void PrintInorder() => printInorder(Root);

        public void PrintPostorder() => printPostorder(Root);

        private void printPreorder(TreeNode? node)
        {
            if (node == null)
                return;

            Console.Write($"{node.Val} ");
            printPreorder(node.Left);
            printPreorder(node.Right);
        }

        private void printInorder(TreeNode? node)
        {
            if (node == null)
                return;

            printInorder(node.Left);
            Console.Write($"{node.Val} ");
            printInorder(node.Right);
        }

        private void printPostorder(TreeNode? node)
        {
            if (node == null)
                return;

            printPostorder(node.Left);
            printPostorder(node.Right);
            Console.Write($"{node.Val} ");
        }
    }
}