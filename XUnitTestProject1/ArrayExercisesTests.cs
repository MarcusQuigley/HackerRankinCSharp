using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HackerRankinCore.Tests
{
    public class ArrayExercisesTests
    {
        [Theory]
        [InlineData(5,new int[]{7,1,3,2,4,5,6})]
        [InlineData(3, new int[] { 4, 3, 1,2})]
        [InlineData(3, new int[] {2,3,4,1,5 })]
        [InlineData(3, new int[] { 1,3,5,2,4,6,7 })]
        public void Minimum_Swaps_works(int expectedResult, int[] array)
        {
         //   var array = ArrayHelper.CreateArray("1 2 5 3 7 8 6 4");
            var ae = new ArrayExercises();
            var result = ae.MinimumSwaps(array);
            Assert.Equal(expectedResult, result);

        }
    }
}
