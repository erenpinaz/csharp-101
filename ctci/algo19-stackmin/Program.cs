using System.Collections.Generic;

namespace algo19_stackmin;
class Program
{
    static void Main(string[] args)
    {
        MinStack stack = new MinStack();
        stack.Push(5);
        stack.Push(6);
        stack.Push(3);
        stack.Push(7);
        stack.Pop();
        stack.Pop();

        Console.WriteLine(stack.Min());
    }
}

public class MinStack : Stack<int>
{
    // O(1) time, O(n) space
    private Stack<int> InnerMinStack;

    public MinStack()
    {
        InnerMinStack = new Stack<int>();
    }

    public new int Pop()
    {
        int value = base.Pop();

        if (value == Min())
            InnerMinStack.Pop();

        return value;
    }

    public new void Push(int value)
    {
        if (value <= Min())
            InnerMinStack.Push(value);

        base.Push(value);
    }

    public int Min()
    {
        if (InnerMinStack.Count == 0)
            return int.MaxValue;
        else
            return InnerMinStack.Peek();
    }
}