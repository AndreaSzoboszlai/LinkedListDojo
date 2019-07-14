using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class Node
    {
        public Node next { get; set; }
        public int Data { get; set; }

        public Node(int d)
        {
            Data = d;
            next = null;
        }

        public void Print()
        {
            Console.Write(" --> " + Data);
            if (next != null)
            {
                next.Print();
            }
        }
        public void AddToEnd(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }
}
