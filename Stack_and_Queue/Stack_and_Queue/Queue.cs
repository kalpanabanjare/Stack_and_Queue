using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
        public class Queue
        {
        LinkedList linklist;
        public Queue()
            {
                linklist = new LinkedList();
            }
            public void Enqueue(Node mode)
            {
                linklist.AddNode(mode);
            }
            public void DisplayQueue()
            {
                Console.WriteLine("Queue: ");
                linklist.DisplayQueue();
            }
            public void Top()
            {
                var val = linklist.Head;
                Console.WriteLine("\nTop" + val.data);
            }
            public void dwqueue(Node node_2)
            {
            linklist.dequeue();
            }
        }
}
