using System;
using System.Linq;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(PigIt("This is my string"));
            Console.ReadKey();
        }


        public static string PigIt(string str)
        {
            int i = 0;
            string[] snew = str.Split(' ').ToArray<string>();
            str = "";
            while (i < snew.Length)
            {
                str += snew[i].Substring(1) + snew[i].Substring(0, 1) + "ay ";
                i++;
            }
            Console.WriteLine(i.ToString("{00}"));

            

            return str.TrimEnd(' ');
            }
        }
    }

