namespace DataStructures.Model
{
    public class CustomQueue<T>
    {
        private class CustomQueueNode
        {
            public T Val;
            public CustomQueueNode? Next;

            public CustomQueueNode(T val)
            {
                this.Val = val;
                this.Next = null;
            }
        }

        private CustomQueueNode? First;
        private CustomQueueNode? Last;

        public void Enqueue(T item)
        {
            CustomQueueNode node = new CustomQueueNode(item);

            if (Last == null)
            {
                First = Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }
        }

        public T Dequeue()
        {
            if (First == null)
                throw new NullReferenceException("Queue is empty!");

            T item = First.Val;
            First = First.Next;

            if (First == null)
                Last = null;

            return item;
        }

        public T Peek() 
        {
            if(First == null)
                throw new NullReferenceException("Queue is empty!");
            
            return First.Val;
        }

        public bool IsEmpty()
        {
            return First == null;
        }
    }
}