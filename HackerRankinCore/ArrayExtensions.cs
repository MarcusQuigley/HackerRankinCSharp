using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankinCore
{
    static class ArrayExtensions
    {
        public static void DisplayArray<T>(this T[] array, Action<T> action = null)
        {
            foreach (var item in array)
            {
                if (action == null)
                {
                    Console.Write($"{item} ");
                }
                else
                {
                    action.Invoke(item);
                }
                //  action == null ? Console.Write($"{item} ") :  action.Invoke(item);

            }
            Console.Write('\n');
        }
    }
}
