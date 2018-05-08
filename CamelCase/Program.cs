using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the_stealth_warrior"));

            Console.ReadKey();
        }

     
        public static string ToCamelCase(string str)
        {
            int i = 1;
            var nstr = str.Split('-', '_').ToArray();
            str = nstr[0];

            while (i<nstr.Length)
            {
                str += nstr[i].First().ToString().ToUpper() + nstr[i].Substring(1);
                i++;
            }
            //Console.WriteLine(nstr[0].ToString().f);
            
            return str;
        }
    
}
}