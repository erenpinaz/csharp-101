namespace DataStructures.Model
{
    public class CustomStack<T>
    {
        private class CustomStackNode
        {
            public T Val;
            public CustomStackNode? Next;

            public CustomStackNode(T val)
            {
                this.Val = val;
                this.Next = null;
            }
        }

        private CustomStackNode? Top;

        public T Pop()
        {
            if (Top == null)
                throw new NullReferenceException("Stack is empty!");

            T item = Top.Val;
            Top = Top.Next;

            return item;
        }

        public void Push(T item)
        {
            CustomStackNode node = new CustomStackNode(item);
            node.Next = Top;
            Top = node;
        }

        public T Peek()
        {
            if (Top == null)
                throw new NullReferenceException("Stack is empty!");

            return Top.Val;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }
}