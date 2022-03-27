using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        public void AddNode(Node node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }
        }                
        public void StackDisplay()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Stack is empty");
            else
                Console.WriteLine("Stack");
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                if (temp.next != null)
                    Console.WriteLine("");
                temp = temp.next;
            }
        }
        public void Peek()
        {
            if (Head == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is in top of the stack", Head.data);
        }
        public void Pop()
        {
            if(Head == null)
            {
                Console.WriteLine("stack is empty");
                return ;
            }
            Console.WriteLine("value poped is {0}", Head.data);
            Head = Head.next;
        }
        internal void IsEmpty()
        {
            while(Head != null)
            {
                Peek();
                Pop();
            }
        }
    }
}
