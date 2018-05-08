using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;     
            long x = 0;

            SortedSet<long> num = new SortedSet<long>
            {
                1
            };
            int n = 15; //nth Hamming number

            do
            {
                x = num.Min;    //Get the least value of num
                num.Add(2 * x); //Add 
                num.Add(3 * x);
                num.Add(5 * x);
                num.Remove(x);
                i++;
            }
            while (i < n);

            Console.Write(x);
            
            Console.ReadKey();
        }
    }
}
