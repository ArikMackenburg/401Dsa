using System;
using Xunit;
using Challenges.Arrays;


namespace Challenges.Test
{
    public class ReverseTest
    {
        [Theory]
        [InlineData(new int[3]{1, 2, 3},new int[3]{3,2,1})]
        [InlineData(new int[3]{4, 5, 6},new int[3]{6,5,4})]
        public void TestReverse(int[] arr, int[]reverse)
        {
            int[] result = Reverse.ReverseArray(arr);

            Assert.Equal(result, reverse);
        }
    }
}
