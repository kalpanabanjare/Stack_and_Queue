using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    public class Stack
    {
        LinkedList linklist;
        public Stack()
        {
            linklist = new LinkedList();
        }
        public void Push(Node node)
        {
            linklist.AddNode(node);
        }
        public void DisplayStack()
        {           
            linklist.StackDisplay();
        }
        public void Top()
        {
            var val = linklist.Head;
            Console.WriteLine("Top" + val.data);
        }
    }
}
