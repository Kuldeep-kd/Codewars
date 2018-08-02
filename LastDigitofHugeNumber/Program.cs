using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;


namespace LastDigitofHugeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 499942, 898102, 846073 };

            Console.WriteLine( LastDigit(arr) );
            Console.ReadKey();

        }

        public static int LastDigit(int[] array)
        {
            if (array.Length == 0 || array.ElementAt(0) == 0)
                return 1;
            List<int> ls = array.ToList();

            uint num = (uint)(ls.Last());
            ls.Remove(ls.Last());

            while (true)
            {
                num = (uint)power(ls.Last(), (int)num);
                ls.Remove(ls.Last());
                if (ls.Count == 0)
                    break;
            }
            return (int)num;

            /*
            BigInteger integer = new BigInteger();
            List<int> list = new List<int>();
            list = array.ToList();

            integer = list.Last();

            foreach (int i in array)
            {
                integer = BigInteger.Pow(list.Last(), (int)integer);
                list.Remove(list.Last());
            }

            return (int)(integer % 10);
            */
        }
        public static int power(int m,int e)
        {
            int temp = 0;
            if ((e % 100) % 4 != 0) //If last two digits of exp % 4 is non zero
                temp = (int)Math.Pow(m % 10, (e % 100) % 4);

            //Then raise to power last two dig of exp % 4

            return (temp % 10 != 0) ? temp : 1;
        }
    }
}