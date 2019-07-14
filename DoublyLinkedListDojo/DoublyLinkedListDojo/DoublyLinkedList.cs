using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListDojo
{
    class DoublyLinkedList
    {
        private Node head;
        public DoublyLinkedList()
        {
            this.head = null;
        }

        public void addToEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                newNode.previous = null;
                head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode(head);
                lastNode.next = newNode;
                newNode.previous = lastNode;
            }
        }
        public void Print()
        {
            if (head != null)
            {
                head.Print();
            }
        }

        private Node GetLastNode(Node head)
        {
            Node temp = head;

            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
