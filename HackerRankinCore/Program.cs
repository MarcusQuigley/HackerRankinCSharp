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
            ////var array = ArrayExercises.CreateArray<int>(5,10);
            //var array = new int[] { 1, 2, 3, 4, 5 };
            //array.DisplayArray();
            //array= ArrayExercises.LeftRotation(4, array);
            //array.DisplayArray();
           // var array = ArrayHelper.CreateArray("2 5 1 3 4");
            var array = ArrayHelper.CreateArray("1 2 5 3 7 8 6 4");
            //  var array = new int[] { 4, 1, 2, 3 };


            ArrayExercises.NewYearsChaos(array);
        }


    }
}
