using System;
using DataStructures.LinkedLists;
using Challenges.LinkedLists;
using System.Text;
using Xunit;

namespace Challenges.Test.LinkedLists
{
    public class LinkedListZipTest
    {
        [Fact]
        public void ZipListsReturnsEmptyForEmptyLists()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            LinkedList result = LinkedListZip.Zip(list1, list2);

            Assert.Equal("NULL",result.ToString());
        }
        [Fact]
        public static void ZipListResults()
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Append(1);
            list1.Append(3);
            list1.Append(2);
            list2.Append(5);
            list2.Append(9);
            list2.Append(4);

            LinkedList expect = new LinkedList();
            expect.Append(1);
            expect.Append(5);
            expect.Append(3);
            expect.Append(9);
            expect.Append(2);
            expect.Append(4);
            LinkedList result = LinkedListZip.Zip(list1, list2);

            Assert.Equal(expect.ToString(), result.ToString());
        }
    }
}
