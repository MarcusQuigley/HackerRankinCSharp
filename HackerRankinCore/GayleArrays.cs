using System;
using System.Collections.Generic;
using System.Text;
 

namespace HackerRankinCore
{
  public  class GayleArrays
    {
        public bool IsUnique(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("value");
            if (value.Length == 1) return true;
            if (value.Length > 26) return false;

            bool occured = false;
            var chars = value.ToLower().ToCharArray();
            for (int i = 0; i < value.Length; i++)
            {
                occured = false;
                for (int j = i; j < value.Length; j++)
                {
                    if (value[j] == value[i])
                    {
                        if (occured)
                            return false;
                        occured = true;
                    }
                }
            }
            return true;
        }
      
        public bool IsUniquewithDS(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentNullException("value");
            if (value.Length == 1) return true;
            if (value.Length > 26) return false;

            HashSet<char> set = new HashSet<char>(value.Length);
            for (int i = 0; i < value.Length; i++)
            {
                if (set.Add(value[i]) == false)
                    return false;
            }
            return true;
        }

        public bool IsPermutation(string arg1, string arg2)
        {
            if (arg1.Length != arg2.Length)
                return false;

            var charArray1 = arg1.ToLower().ToCharArray();
            var charArray2 = arg2.ToLower().ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);
            for (int i = 0; i < charArray1.Length; i++)
            {
                if (charArray1[i] != charArray2[i])
                    return false;
            }

            return true;
        }

        public bool IsPermutation2(string arg1, string arg2)
        {
            if (arg1.Length != arg2.Length)
                return false;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            var charArray1 = arg1.ToLower().ToCharArray();
            var charArray2 = arg2.ToLower().ToCharArray();

            for (int i = 0; i < charArray1.Length; i++)
            {
                if (!dict.ContainsKey(charArray1[i]))
                {
                    dict.Add(charArray1[i], 0);
                }
                dict[charArray1[i]] += 1;
            }

            for (int i = 0; i < charArray2.Length; i++)
            {
                if (!dict.ContainsKey(charArray2[i]))
                {
                    return false;
                }
                dict[charArray2[i]] -= 1;
                if (dict[charArray2[i]] < 0)
                    return false;
            }

            return true;
        }

        public void Urlify(string arg)
        {
            //replace all spaces with "%20"
            const string replacement = "%20";
             

            int posnFromEnd = arg.Length-1;
            StringBuilder sb = new StringBuilder(arg.Length);
            char[] array = arg.ToCharArray();
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != ' ')
                {
                    sb.Append(array[i]);
                }
                else
                {
                    sb.Append(replacement);
                    posnFromEnd -= replacement.Length;
                }
                if (i == posnFromEnd)
                    break;
            }
            Console.WriteLine($"'{sb.ToString()}'");
        }

        public void Urlify(string arg, int properLength)
        {
            char[] array = arg.ToCharArray();
            char[] replacement = { '%', '2', '0' };

            int numSpaces = (array.Length - properLength) / replacement.Length;

            int properIndex = properLength;
            int index = array.Length - 1;
            //   for (int index = array.Length-1; index >0; index--)
            for (int i = properIndex - 1; i > 0; i--)
            {
                if (array[i]!=' ')
                {
                    array[index--] = array[i];
                    //properIndex -= 1;
                }
                else
                {
                    array[index--] = '0';
                    array[index--] = '2';
                    array[index--] = '%';
                }
            }
            Console.WriteLine($"[{new string(array)}]");
        }

        public bool IsPalindrome(string arg)
        {
            if (string.IsNullOrEmpty(arg))
                throw new ArgumentNullException("arg");
            if (arg.Length == 1) return true;
            arg = arg.ToLower();
            int[] map = new int[128];
            int counter = 0;
            for (int i = 0; i < arg.Length; i++)
            {
                char c = arg[i];
                if (map[(int)c] == 0)
                {
                    map[(int)c] = 1;
                    counter += 1;
                }
                else
                {
                    map[(int)c] = 0;
                    counter -= 1;
                }
            }

            
 
            if (arg.Length % 2 == 0)
            {
                if (counter == 0) return true;
             }
            else
            {
                if (counter == 1) return true;
            }

            return false;
         }
    }
}
