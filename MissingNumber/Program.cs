using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MissingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> plist = new List<int>();
            plist.Add(1040);
            plist.Add(1220);
            plist.Add(1580);
            Console.WriteLine( FindMissing(plist));
            Console.ReadKey();
        }


        public static int FindMissing(List<int> list)
        {

#pragma warning disable
            int[] xlist = list.ToArray();
            int d = 0, i = 0, x = xlist[0];

            if (xlist[1] - xlist[0] == xlist[2] - xlist[1])
            {
                d = xlist[1] - xlist[0];
            }
            else
            {
                d = xlist[xlist.Length-1] - xlist[xlist.Length - 2];
            }

            Console.WriteLine("The length of array is {0}", xlist.Length);
            Console.WriteLine("The difference of array is {0}", d);

            while (i <= xlist.Length)
            {
                if (xlist[i] != x)
                {
                    return x;
                    goto end;
                }
                x += d;
                i++;

            }
            return 0;

        end:;
#pragma warning restore
        }
    }
}
