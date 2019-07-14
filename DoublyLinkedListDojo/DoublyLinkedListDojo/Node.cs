using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListDojo
{
    class Node
    {
        public Node next { get; set; }
        public Node previous { get; set; }
        public int Data { get; set; }

        public Node(int d)
        {
            Data = d;
            next = null;
            previous = null;
        }


        public void Print()
        {
            Console.Write(" --> " + Data);
            if (next != null)
            {
                next.Print();
            }
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
