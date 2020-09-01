using DataStructures.LinkedLists;
using System;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class LinkedListTests
    {
        [Fact]
        public void LinkedList_starts_empty()
        {
            // Act
            LinkedList list = new LinkedList();

            // Assert
            Assert.Equal("NULL", list.ToString());
        }

        [Fact]
        public void Insert_adds_value_to_start()
        {
            // Arrange
            LinkedList list = new LinkedList();

            // Act
            list.Insert(1);

            // Assert
            Assert.Equal("{ 1 } -> NULL", list.ToString());

            // Act
            list.Insert(2);

            // Assert
            Assert.Equal("{ 2 } -> { 1 } -> NULL", list.ToString());
        }
        [Theory]
        [InlineData(1,true)]
        [InlineData(4, true)]
        [InlineData(7,false)]
        public void Includes_True_False(int val, bool expect)
        {
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(3);
            list.Insert(4);

            Assert.Equal(expect, list.Includes(val));

        }

        [Fact]
        public void Append_adds_value_to_end()
        {
            LinkedList list = new LinkedList();

            list.Append(1);

            Assert.Equal("{ 1 } -> NULL", list.ToString());

            list.Append(2);

            Assert.Equal("{ 1 } -> { 2 } -> NULL", list.ToString());
        }

        [Theory]
        [InlineData(2, 5, "{ 1 } -> { 5 } -> { 2 } -> { 3 } -> NULL")]
        [InlineData(4, 5, "{ 1 } -> { 2 } -> { 3 } -> NULL")]
        public void Insert_before_inserts_before(int value, int newValue, string expect)
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.InsertBefore(value, newValue);

            Assert.Equal(expect, list.ToString());

        }

        [Theory]
        [InlineData(2, 5, "{ 1 } -> { 2 } -> { 5 } -> { 3 } -> NULL")]
        [InlineData(4, 5, "{ 1 } -> { 2 } -> { 3 } -> NULL")]
        public void Insert_after_inserts_after(int value, int newValue, string expect)
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(2);
            list.Append(3);

            list.InsertAfter(value, newValue);

            Assert.Equal(expect, list.ToString());

        }

        [Theory]
        [InlineData(0,2)]
        [InlineData(2,3)]
        public void K_value_equals(int k,int expect)
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(8);
            list.Append(2);

            Assert.Equal(expect, list.KthFromTheEnd(k));
        }
        [Fact]
        public void K_out_of_range()
        {
            LinkedList list = new LinkedList();
            list.Append(1);
            list.Append(3);
            list.Append(8);
            list.Append(2);

            Exception ex = Assert.Throws<OutOfRangeException>(() =>
            {
                list.KthFromTheEnd(8);
            });
            Assert.Equal("8", ex.Message);
        }

    }
}