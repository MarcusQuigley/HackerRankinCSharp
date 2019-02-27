using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankinCore
{
    public class ArrayExercises
    {
        public static T[] CreateArray<T>(int length = -1, int maxNumber = 1000)
        {
            Random r = new Random();
            if (length == -1)
            {
                length = r.Next() * 1000;
            }
            int[] arr = new int[length];
            T[] array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = (T)Convert.ChangeType(r.Next(maxNumber), typeof(T));
            }
            return array;
        }
        public static void NewYearsChaosBad(int[] q) {
            if (q is null || q.Length < 2) {
                Console.WriteLine(0);
                return;
            }

            int moves = 0;
            int bribes = 0;
            for (int i = 1; i <= q.Length; i++)
            {
                if (q[i - 1] > i)
                {
                    bribes = (q[i - 1] - i);
                    if (bribes > 2)
                    {
                        Console.WriteLine("Too chaotic");
                        return;
                    }
                    moves += bribes;
                }
            }
            Console.WriteLine(moves);

        }

        //1 2 5 3 7 8 6 4
        //4,1,2,3
        public static void NewYearsChaos(int[] q)
        {
            int ans = 0;
            for (int i = q.Length-1; i >=0; i--)
            {
                if (q[i] -(i+1) > 2) {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                // for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                for (int j = 0; j < i; j++)
                    if (q[j] > q[i]) ans++;
            }
            Console.WriteLine(ans);
        }

        public static T[] LeftRotation<T>(int rotations, T[] array)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (rotations < 1)
                return array;
             
            Console.WriteLine($"Rotating left {rotations} times");
            int numToRotate = array.Length - rotations;
            int rotateFrom = 0;
            T[] newArray = new T[array.Length]  ;
            for (int i = 0; i < array.Length; i++)
            {
                rotateFrom = (i + rotations) % array.Length;
                newArray[i] = array[rotateFrom];
            }

            return newArray;
        }

        public static int[] LeftRotation(int rotations, int[] array)
        {
            var left = array.Take(rotations);
            var right = array.Skip(rotations).Take(array.Length - rotations);
            return right.Concat(left).ToArray();
         }

        public int MinimumSwaps(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException("array");

            if (array.Length == 1)
                return 1;
            int swaps = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != i + 1)
                {
                    int t = i+1;
                    while (array[t] != i + 1)
                    {
                        t++;
                    }
                    int temp = array[t];
                    array[t] = array[i];
                    array[i]= temp ;
                    swaps++;
                }
            }
            
            return swaps;
        }



     }
}
