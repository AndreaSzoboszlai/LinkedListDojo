using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListDojo
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList dL = new DoublyLinkedList();
            dL.addToEnd(2);
            dL.addToEnd(1);
            dL.addToEnd(9);
            dL.Print();
            Console.ReadLine();
            dL.DeleteNodebyKey(1);
            dL.Print();
            Console.ReadLine();
        }
    }
}
