using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using Xunit;
using Challenges.Arrays;

namespace Challenges.Test.Arrays
{
    public class ArrayTest
    {
        [Fact]
        public void InsertSortTest()
        {
            var arr = new int[] { 10, 5, 3, 12, 45 };
            var expect = new int[] { 3, 5, 10, 12, 45 };

            Assert.Equal(expect, Sorts.InsertionSort(arr));
        }

        [Fact]
        public void MergeSortTest()
        {
            var arr = new int[] { 10, 5, 3, 12, 45 };
            var expect = new int[] { 3, 5, 10, 12, 45 };

            Assert.Equal(expect, Sorts.MergeSort(arr));
        }
        [Fact]
        public void QuickSortTest()
        {
            var arr = new int[] { 10, 5, 3, 12, 45,90,110,100,120 };
            var expect = new int[] { 3, 5, 10, 12, 45,90,100,110,120 };

            Assert.Equal(expect, Sorts.QuickSort(arr,0,8));
        }

    }
}
