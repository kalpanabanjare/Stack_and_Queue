using Stack_and_Queue;
using System;

namespace Stack_And_Queue
{
    class Program
    {
        static void Main()
        {
            LinkedList linklist = new LinkedList();
            Node node_1 = new Node(56);
            Node node_2 = new Node(30);
            Node node_3 = new Node(70);
            
            Stack stack = new Stack();
            stack.Push(node_1);
            stack.Push(node_2);
            stack.Push(node_3);
            stack.DisplayStack();
            stack.Top();

            stack.Pop(node_1);
            stack.Pop(node_1);
            stack.Pop(node_1);
            stack.DisplayStack();

            Queue queue = new Queue();
            queue.Enqueue(node_1);
            queue.Enqueue(node_2);
            queue.Enqueue(node_3);            
            queue.DisplayQueue();
            queue.Top();

            queue.dwqueue(node_1);
            queue.dwqueue(node_2);
            queue.dwqueue(node_3);
            queue.DisplayQueue();
        }

    }
}