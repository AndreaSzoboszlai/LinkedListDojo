using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList sL = new SingleLinkedList();
            sL.addToEnd(7);
            sL.addToEnd(5);
            sL.addToEnd(1);
            sL.addToEnd(9);
            sL.deleteNodeByKey(1);
            sL.Print();
            Console.ReadLine();
        }
    }
}
