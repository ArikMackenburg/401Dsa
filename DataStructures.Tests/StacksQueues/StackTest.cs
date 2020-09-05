using System;
using DataStructures.StacksQueues;

using Xunit;

namespace DataStructures.Tests.StacksQueues
{
    public class StackTest
    {
        
        [Fact]
        public void Stack_starts_empty()
        {
            // Act
            Stack<int> stack = new Stack<int>();

            // Assert
            Assert.Equal("NULL", stack.ToString());
        }
        [Fact]
        public void Push_adds_to_top()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(2);
            stack.Push(3);

            Assert.Equal("{ 3 } -> { 2 } -> NULL", stack.ToString());
        }
        [Fact]
        public void Pop_removes_top()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(2);
            stack.Push(3);

            Assert.Equal(3, stack.Pop());

            Assert.Equal("{ 2 } -> NULL", stack.ToString());

        }
        [Fact]
        public void Pop_on_empty_exception()
        {
            Stack<string> stack = new Stack<string>();

            Exception ex = Assert.Throws<EmptyStackException>(() =>
            {
                stack.Pop();
            });
            Assert.Equal("Stack is empty", ex.Message);
        }
        [Fact]
        public void Peek_shows_top()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(2);
            stack.Push(3);

            Assert.Equal(3, stack.Peek());

            Assert.Equal("{ 3 } -> { 2 } -> NULL", stack.ToString());

        }
        [Fact]
        public void Peek_on_empty_exception()
        {
            Stack<string> stack = new Stack<string>();

            Exception ex = Assert.Throws<EmptyStackException>(() =>
            {
                stack.Peek();
            });
            Assert.Equal("Stack is empty", ex.Message);
        }
        [Fact]
        public void IsEmpty_True_False()
        {
            Stack<int> stack = new Stack<int>();
            Assert.True(stack.isEmpty());
            stack.Push(1);
            Assert.False(stack.isEmpty());
        }
    }
}
