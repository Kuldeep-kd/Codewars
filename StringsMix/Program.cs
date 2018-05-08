using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringsMix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mix("Are they here", "yes, they are here"));
            Console.ReadKey();
        }


        public static string Mix(string s1, string s2)
        {
            s1 = s1.Replace(",", "").Replace(".", "").Replace("!", "").ToLower();
            s2 = s2.Replace(",", "").Replace(".", "").Replace("!", "").ToLower();

            char[] as1 = s1.Distinct<char>().ToArray<char>();
            char[] as2 = s2.Distinct<char>().ToArray<char>();


            Array.Sort(as1); Array.Sort(as2);

            


            Console.WriteLine(string.Join(" ", as1));
            Console.WriteLine(string.Join(" ", as2));

            return "";
        }


    }
}
