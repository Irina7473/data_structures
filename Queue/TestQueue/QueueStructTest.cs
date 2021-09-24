using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueueSharpLib;
using System;

namespace TestQueue
{
    [TestClass]
    public class QueueStructTest
    {
        [TestMethod]
        public void Test_Pop_Success()
        {
            // Arrange
            int expected = 5;
            QueueStruct<int> queue = new QueueStruct<int>();
            queue.Push(5);
            queue.Push(3);
            queue.Push(1);

            // Act
            var actual = queue.Pop();

            // Assert            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException (typeof(IndexOutOfRangeException), "Нет исключения")]
        public void Test_Pop_Exceptoin()
        {
            // Arrange            
            QueueStruct<int> queue = new QueueStruct<int>();            

            // Act
            var actual = queue.Pop();            
        }

        [TestMethod]
        public void Test_Last_Success()
        {
            // Arrange
            int expected = 1;
            QueueStruct<int> queue = new QueueStruct<int>();
            queue.Push(5);
            queue.Push(3);
            queue.Push(1);

            // Act
            var actual = queue.Last;

            // Assert            
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException), "Нет исключения")]
        public void Test_Last_Exceptoin()
        {
            // Arrange            
            QueueStruct<int> queue = new QueueStruct<int>();
            
            // Act
            var actual = queue.Last;
        }
    }
}