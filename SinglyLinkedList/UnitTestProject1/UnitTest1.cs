using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SinglyLinkedList;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        SingleLinkedList sL;

        [TestInitialize]
        public void SetUp()
        {
            sL = new SingleLinkedList();
            sL.head = new Node(7);
            sL.head.next = new Node(5);
            sL.head.next.next = new Node(1);
            sL.head.next.next.next = new Node(9);
        }

        [TestCleanup]
        public void TearDown()
        {

        }

        [TestMethod]
        public void TestHead()
        {
            int head = sL.head.Data;
            Assert.AreEqual(7, head, "List head is not correct");

        }

        [TestMethod]
        public void TestTail()
        {
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
            sL.addToEnd(7);


            Node tail = sL.head;
            int count = 1;
            while (tail.next != null)
            {
                tail = tail.next;
                count++;
            }
            Assert.AreEqual(5, count, "List add is not correct");
        }

        [TestMethod]
        public void TestRemove()
        {
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
