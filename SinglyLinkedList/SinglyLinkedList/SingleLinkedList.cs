using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SingleLinkedList
    {
        public Node head { get; set; }

        public SingleLinkedList()
        {
            this.head = null;
        }

        public void addToEnd(int data)
        {
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                head.AddToEnd(data);
            }
        }
        public void Print()
        {
            if (head != null)
            {
                head.Print();
            }
        }

        public void deleteNodeByKey(int key)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.Data == key)
            {
                head = temp.next;
            }
            while (temp != null && temp.Data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            prev.next = temp.next;

        }

        public void InsertFront(SingleLinkedList singlyList, int new_data)
        {

            Node new_node = new Node(new_data);
            new_node.next = singlyList.head;
            singlyList.head = new_node;
        }
    }
}
