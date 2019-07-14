using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SinglyLinkedList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHead()
        {
            SingleLinkedList sL = new SingleLinkedList();
            sL.addToEnd(7);
            sL.addToEnd(5);
            sL.addToEnd(1);
            sL.addToEnd(9);

            int head = sL.head.Data;
            Assert.AreEqual(7, head, "List head is not correct");

        }

        [TestMethod]
        public void TestTail()
        {
            SingleLinkedList sL = new SingleLinkedList();
            sL.addToEnd(7);
            sL.addToEnd(5);
            sL.addToEnd(1);
            sL.addToEnd(9);

            Node tail = sL.head;
            while (tail.next != null)
            {
                tail = tail.next;
            }
            Assert.AreEqual(9, tail.Data, "List tail is not correct");
        }

        [TestMethod]
        public void TestLength()
        {
            SingleLinkedList sL = new SingleLinkedList();
            sL.addToEnd(7);
            sL.addToEnd(5);
            sL.addToEnd(1);
            sL.addToEnd(9);

            Node tail = sL.head;
            int count = 1;
            while (tail.next != null)
            {
                tail = tail.next;
                count++;
            }
            Assert.AreEqual(4, count, "List length is not correct");
        }
        [TestMethod]
        public void TestAdd()
        {
            SingleLinkedList sL = new SingleLinkedList();
            sL.addToEnd(7);


            Node tail = sL.head;
            int count = 1;
            while (tail.next != null)
            {
                tail = tail.next;
                count++;
            }
            Assert.AreEqual(1, count, "List add is not correct");
        }
        [TestMethod]
        public void TestRemove()
        {
            SingleLinkedList sL = new SingleLinkedList();
            sL.addToEnd(7);
            sL.addToEnd(5);
            sL.addToEnd(1);
            sL.addToEnd(9);
            sL.deleteNodeByKey(1);

            Node tail = sL.head;
            int count = 1;
            while (tail.next != null)
            {
                tail = tail.next;
                count++;
            }
            Assert.AreEqual(3, count, "List remove is not correct");
        }
    }
}
