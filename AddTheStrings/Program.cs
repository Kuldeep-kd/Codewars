using System;
using System.Numerics;

namespace AddTheStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( sumStrings(string.Empty, "4000000000000000000") );
            Console.ReadKey();
        }

        public static string sumStrings(string a, string b)
        {
            BigInteger demo;

            BigInteger ans = (BigInteger.TryParse(a, out demo)) ? (BigInteger.Parse(a)) : 0;
                       ans += (BigInteger.TryParse(b, out demo)) ? (BigInteger.Parse(b)) : 0;
            return ans.ToString();
        }
    }
}