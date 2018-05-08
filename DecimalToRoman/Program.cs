using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution(Int32.Parse(Console.ReadLine()));
            Console.WriteLine(Solution(1954));
            Console.ReadKey();
        }



        public static string Solution(int n)
        {
            string ans="";

            while (n > 0)
            {
                if (n - 1000 >= 0)
                {
                    ans += "M";
                    n -= 1000;
                }

                if (n - 900 >= 0 && n < 1000)
                {
                    ans += "CM";
                    n -= 900;
                }
                
                if (n - 90 >= 0 && n < 100)
                {
                    ans += "XC";
                    n -= 90;
                }

                if (n - 9 >= 0 && n < 10)
                {
                    ans += "IX";
                    n -= 9;
                }

                if (n - 500 >= 0 && n < 1000)
                {
                    ans += "D";
                    n -= 500;
                }

                if (n - 100 >= 0 && n < 500)
                {
                    ans += "C";
                    n -= 100;
                }


                if (n - 50 >= 0 && n < 100)
                {
                    ans += "L";
                    n -= 50;
                }
                

                if (n - 10 >= 0 && n < 50)
                {
                    ans += "X";
                    n -= 10;
                }

                if (n - 4 >= 0 && n < 5)
                {
                    ans += "IV";
                    n -= 4;
                }

                if (n - 5 >= 0 && n < 10)
                {
                    ans += "V";
                    n -= 5;
                }

                if (n - 1 >= 0 && n < 5)
                {
                    ans += "I";
                    n -= 1;
                }

            }


            return ans;
        }



    }
}
