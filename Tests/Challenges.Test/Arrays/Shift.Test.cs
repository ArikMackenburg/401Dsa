using System;
using Xunit;
using Challenges.Arrays;

namespace Challenges.Test.Arrays
{
    public class ShiftTest
    {
        [Theory]
        [InlineData(new int[4] { 1, 2, 4, 5 },3,new int[5] { 1, 2, 3, 4, 5 })]
        [InlineData(new int[2] { 1, 3 }, 2, new int[3] { 1, 2, 3})]
        [InlineData(new int[6] { 1, 2, 3, 5, 6, 7}, 4, new int[7] { 1, 2, 3, 4, 5, 6, 7 })]
        public void TestShift(int[] arr,int num, int[] shiftedArray)
        {
            
            int[] result = Shift.ShiftArray(arr, num);
            Assert.Equal(result, shiftedArray);
        }
    }
}
