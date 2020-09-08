using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DataStructures.StacksQueues;

namespace DataStructures.Tests.StacksQueues
{
    public class PseudoQueueTests
    {
        
        [Fact]
        public void PseudoQueue_starts_empty()
        {
            PseudoQueue<int> q = new PseudoQueue<int>();

            Assert.Equal("NULL", q.ToString());

        }
        [Fact]
        public void DeQueue_throws_EmptyEx_on_empty()
        {
            PseudoQueue<int> q = new PseudoQueue<int>();

            Exception ex = Assert.Throws<EmptyStackException>(() =>
            {
                q.DeQueue();
            });
            Assert.Equal("Stack is empty", ex.Message);
        }
        [Fact]
        public void Enqueue_adds_to_end()
        {
            PseudoQueue<int> q = new PseudoQueue<int>();

            q.EnQueue(3);
            q.EnQueue(2);

            Assert.Equal("{ 3 } -> { 2 } -> NULL", q.ToString());

        }
        [Fact]
        public void Peek_throws_EmptyEx_on_empty()
        {
            PseudoQueue<int> q = new PseudoQueue<int>();

            Exception ex = Assert.Throws<EmptyStackException>(() =>
            {
                q.Peek();
            });
            Assert.Equal("Stack is empty", ex.Message);
        }
        [Fact]
        public void Peek_return_Front()
        {
            PseudoQueue<int> q = new PseudoQueue<int>();
            q.EnQueue(3);
            q.EnQueue(2);

            Assert.Equal(3, q.Peek());
        }
        [Fact]
        public void IsEmpty_True_False()
        {
            PseudoQueue<int> q = new PseudoQueue<int>();
            Assert.True(q.isEmpty());
            q.EnQueue(1);
            Assert.False(q.isEmpty());

        }
    }
}
