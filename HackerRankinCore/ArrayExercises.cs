using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRankinCore
{
    class ArrayExercises
    {
        


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

           // return null;
        }



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
    }
}
