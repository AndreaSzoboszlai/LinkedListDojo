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
        public int data { get; set; }

        public Node(int d)
        {
            data = d;
            next = null;
            previous = null;
        }


        public void Print()
        {
            Console.Write(" --> " + data);
            if (next != null)
            {
                next.Print();
            }
        }

        public override string ToString()
        {
            return data.ToString();
        }
    }
}
