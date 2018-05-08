using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Numerics;


namespace LargeFactorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(9));
            Console.ReadKey();

        }

        public static string Factorial(int n)
        {
            BigInteger b;
            
            while (n > 1)
            {
                b *= n;
                n--;
            }
            
            return (b>0)? b.ToString() : "";


        }
    }
}
