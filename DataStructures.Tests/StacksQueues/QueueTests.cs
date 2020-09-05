using System;

using System.Text;
using Xunit;
using DataStructures.StacksQueues;

namespace DataStructures.Tests.StacksQueues
{
    public class QueueTests
    {
        [Fact]
        public void Enqueue_starts_empty()
        {
            Queue<int> q = new Queue<int>();

            Assert.Equal("NULL", q.ToString());

        }
        [Fact]
        public void DeQueue_throws_EmptyEx_on_empty()
        {
            Queue<int> q = new Queue<int>();

            Exception ex = Assert.Throws<EmptyQueueException>(() =>
            {
                q.DeQueue();
            });
            Assert.Equal("Queue is empty", ex.Message);
        }
        [Fact]
        public void Enqueue_adds_to_end()
        {
            Queue<int> q = new Queue<int>();

            q.EnQueue(3);
            q.EnQueue(2);

            Assert.Equal("{ 3 } -> { 2 } -> NULL", q.ToString());

        }
        [Fact]
        public void Peek_throws_EmptyEx_on_empty()
        {
            Queue<int> q = new Queue<int>();

            Exception ex = Assert.Throws<EmptyQueueException>(() =>
            {
                q.Peek();
            });
            Assert.Equal("Queue is empty", ex.Message);
        }
        [Fact]
        public void Peek_return_Front()
        {
            Queue<int> q = new Queue<int>();
            q.EnQueue(3);
            q.EnQueue(2);

            Assert.Equal(3, q.Peek());
        }
        [Fact]
        public void IsEmpty_True_False()
        {
            Queue<int> q = new Queue<int>();
            Assert.True(q.isEmpty());
            q.EnQueue(1);
            Assert.False(q.isEmpty());

        }
    }
}
