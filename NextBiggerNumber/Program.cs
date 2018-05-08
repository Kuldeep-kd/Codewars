using System;
using System.Linq;
using System.Numerics;
using System.Collections.Generic;

namespace NextBiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NextBiggerNumber(59884848483559));
            Console.ReadKey();
        }

        public static long NextBiggerNumber(long n)
        {


            long original = n;
            List<char> list = new List<char>();
            List<char> temp = new List<char>();
            
            foreach (char item in n.ToString())
            {
                list.Add(item);
            }

            if (list.Distinct().ToArray().Length <= 1)
                return -1;

            list.Sort();
            string s = string.Join("", list);

            while (true)
            {
                n++;
                temp = n.ToString().ToList();
                temp.Sort();
                if (s == string.Join("", temp))
                {
                    return n;
                }
                if (n-original >= 1000000)
                    break;
            }

            return -1;
        }
    }
}
