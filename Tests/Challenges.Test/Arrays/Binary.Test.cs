using System;
using Challenges.Arrays;
using Xunit;

namespace Challenges.Test.Arrays
{
    public class BinaryTests
    {
        
        
        [Theory]
        [InlineData(new int[4] { 1, 2, 4, 5 }, 4, 2)]
        [InlineData(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 1, 0)]
        [InlineData(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 11, -1)]

        public void BinaryTest(int[] arr, int num, int expected)
        {
            int result = Binary.BinarySearch(arr, num);

            Assert.Equal(expected, result);
        }
    }
}
