using System;

namespace HackerRankinCore
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArrays();
          //  TestGaylesArrays();
            Console.ReadKey();
        }

        static void TestArrays()
        {
            var ae = new ArrayExercises();
            ////var array = ArrayExercises.CreateArray<int>(5,10);
            //var array = new int[] { 1, 2, 3, 4, 5 };
            //array.DisplayArray();
            //array= ArrayExercises.LeftRotation(4, array);
            //array.DisplayArray();
            // var array = ArrayHelper.CreateArray("2 5 1 3 4");
            var array = ArrayHelper.CreateArray("1 2 5 3 7 8 6 4");
            //  var array = new int[] { 4, 1, 2, 3 };

          Console.WriteLine( ae.MinimumSwaps(new int[] { 7, 1, 3, 2, 4, 5, 6 }));
         //   ArrayExercises.NewYearsChaos(array);
         
        }

        static void TestGaylesArrays()
        {
            GayleArrays ga = new GayleArrays();
            //Console.WriteLine($"is unique { ga.IsUnique("9349rffmfi3")}");
            //Console.WriteLine($"is unique { ga.IsUnique("marcus")}");
            //Console.WriteLine($"is unique { ga.IsUniquewithDS("marcus")}");
            //Console.WriteLine($"is unique { ga.IsUniquewithDS("hello")}");

            //Console.WriteLine($"is permutation { ga.IsPermutation("349rffmfi3", "543545frer")}");
            //Console.WriteLine($"is permutation { ga.IsPermutation("Navan", "aannv")}");
            //Console.WriteLine($"is permutation { ga.IsPermutation2("dog", "god")}");
            //Console.WriteLine($"is permutation { ga.IsPermutation2("349rffmfi3", "543545frer")}");

            ga.Urlify("Mr John Smith      ",13);
        }
       
    }
}
