using System;
using System.Linq;

namespace RomanToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string roman= "MDCLXVI";

            int a = 0, index=0;

            foreach (char c in roman)
            {
                if(index < roman.Length-1)
                    index++;

                try
                {

                    if (c == 'I' && roman.ElementAt(index) != 'I')
                        a -= 1;
                    else if (c == 'I')
                        a += 1;


                    if (c == 'V')
                        a += 5;

                    if (c == 'X' && roman.ElementAt(index) == 'C')
                        a -= 10;
                    else if (c == 'X')
                        a += 10;

                    if (c == 'L')
                        a += 50;

                    if (c == 'C' && roman.ElementAt(index) == 'M')
                        a -= 100;
                    else if (c == 'C')
                        a += 100;

                    if (c == 'D')
                        a += 500;

                    if (c == 'M')
                        a += 1000;

                }catch(Exception ex)
                {

                }

            }

            Console.WriteLine(a);
            Console.ReadKey();
        }
    
    }
}
