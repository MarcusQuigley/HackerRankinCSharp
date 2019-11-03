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
        [Theory]
        [InlineData(10, 10)]
        public void ArrayManipulation1(int emptyArrayLength, int expectedResult)
        {
            int[][] queries = new int[][] { new int[] { 1,5,3}, new int[] { 4,8,7}, new int[] {6,9,1} };
            var ae = new ArrayExercises();
            var result = ae.ArrayManipulation(emptyArrayLength, queries);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, 200)]
        public void ArrayManipulation2(int emptyArrayLength, int expectedResult)
        {
            int[][] queries = new int[][] { new int[] { 1, 2,100 }, new int[] { 2,5, 100 }, new int[] { 3,4, 100 } };
            var ae = new ArrayExercises();
            var result = ae.ArrayManipulation(emptyArrayLength, queries);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(10, 31)]
        public void ArrayManipulation3(int emptyArrayLength, int expectedResult)
        {
            int[][] queries = new int[][] { new int[] {2,6,8}, new int[] { 3,5,7 }, new int[] {1,8,1 }, new int[] { 5,9,15} };
            var ae = new ArrayExercises();
            var result = ae.ArrayManipulation(emptyArrayLength, queries);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5, 200)]
        public void ArrayManipulation4(int emptyArrayLength, int expectedResult)
        {
            int[][] queries = new int[][] { new int[] {1,2, 100 }, new int[] { 2, 5, 100 }, new int[] { 3,4, 100 }};
            var ae = new ArrayExercises();
            var result = ae.ArrayManipulation(emptyArrayLength, queries);
            Assert.Equal(expectedResult, result);
        }
        [Theory]
        [InlineData(new int[] {1,4,3,2 }, new int[] { 2,3,4,1 })]
        [InlineData(new int[] { 1}, new int[] { 1 })]
        [InlineData(new int[] {  }, new int[] {  })]
        public void TestArrayReverse(int[] array, int[] expectedResult)
        {
            var ae = new ArrayExercises();
            var result = ae.ReverseArray(array);
            Assert.Equal(expectedResult, result);
        }
         
    }
}
