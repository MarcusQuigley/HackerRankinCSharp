using System;

namespace HackerRankinCore
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArrays();
            Console.ReadKey();
        }

        static void TestArrays()
        {
            //var array = ArrayExercises.CreateArray<int>(5,10);
            var array = new int[] { 1, 2, 3, 4, 5 };
            array.DisplayArray();
            array= ArrayExercises.LeftRotation(4, array);
            array.DisplayArray();
        }
    }
}
