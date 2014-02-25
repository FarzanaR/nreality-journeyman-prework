using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
using System.Collections.Generic;

namespace DataStructuresTest
{
    [TestClass]
    public class QueueTests
    {
        CustomQueue _customQueue;

        [TestInitialize]
        public void Setup()
        {
            _customQueue = new CustomQueue();
        }

        [TestMethod]
        public void TestPush()
        {
            var queue = _customQueue.queue = new List<object>{1, 2};

            Assert.AreEqual(queue.Count, 2);

            _customQueue.PUSH(3);

            Assert.AreEqual(queue.Count, 3);
       
        }

        [TestMethod]
        public void TestPull()
        {
            var queue = _customQueue.queue = new List<object> { 1, 2, 3, 4, 5, 6 };

            Assert.AreEqual(queue.Count, 6);

            _customQueue.PULL();

            Assert.AreEqual(queue.Count, 5);

            Assert.IsFalse(queue.Contains(6));
        }

        [TestMethod]
        public void TestPullFromIndex()
        {
            var queue = _customQueue.queue = new List<object> { 1, 2, 3, 4, 5, 6 };

            Assert.AreEqual(queue.Count, 6);

            _customQueue.PULL(3);

            Assert.AreEqual(queue.Count, 5);

            Assert.IsFalse(queue.Contains(4));
        }

        [TestMethod]
        public void TestSearch()
        {
            var queue = _customQueue.queue = new List<object> { "John", "Jane", "Mary", "Joe"};

            int index = _customQueue.SEARCH("Mary");

            Assert.AreEqual(index, 2);
        }
    }
}
