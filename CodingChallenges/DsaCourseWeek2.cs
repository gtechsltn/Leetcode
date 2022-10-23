class DsaCourseWeek2
{

}

public class StackUsingLinkedList
{
    private Node first = null;
    class Node
    {
        public string Item { get; set; }
        public Node Next { get; set; }
    }

    public bool IsEmpty()
    {
        //check if node points to NULL, then the list is null, then the stack is empty
        return first == null;
    }

    public void Push(string str)
    {
        // inserts a new node at the start of the linked list
        Node oldFirst = first;
        first = new Node();
        first.Item = str;
        first.Next = oldFirst;
    }

    public string Pop()
    {
        string item = first.Item;
        first = first.Next;
        return item;
    }
}

public class StackUsingArray
{
    public string[] strings { get; set; }
    public int N { get; set; } = 0;
    public StackUsingArray(int capacity)
    {
        strings = new string[capacity];
    }

    public bool IsEmpty()
    {
        return N == 0;
    }
    public void Push(string str)
    {
        strings[N] = str;
        N++;
    }
    public string Pop()
    {
        return strings[--N];
    }
}

public class QueueUsingLinkedList
{
    private Node first;
    private Node last;

    class Node
    {
        public string Item { get; set; }
        public Node Next { get; set; }
    }

    public bool IsEmpty()
    {
        return first == null;
    }

    public void Enqueue(string item)
    {
        Node oldLast = last;
        last = new Node();
        last.Item = item;
        last.Next = null;

        if (IsEmpty())
        {
            first = last;
        }
        else
        {
            oldLast.Next = last;
        }
    }

    public string Dequeue()
    {
        string item = first.Item;
        first = first.Next;
        if (IsEmpty())
        {
            last = null;
        }

        return item;
    }
}