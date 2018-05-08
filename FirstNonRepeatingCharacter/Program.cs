using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstNonRepeatingCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstNonRepeatingLetter("sTress"));
            Console.ReadKey();
        }
        public static string FirstNonRepeatingLetter(string s)
        {
            int i = 0;

            char[] x = s.ToLower().ToArray<char>();


#pragma warning disable
            
            if (s.Length > 0)
            {
                while (i < s.Length)
                {
                   
                   
                        if (s.IndexOf(s.Substring(i, 1)) == s.LastIndexOf(s.Substring(i, 1))  || s.IndexOf(s.Substring(i, 1).ToLower()) == s.LastIndexOf(s.Substring(i, 1).ToLower()))
                        {
                            return s.Substring(i, 1);
                            break;
                        }
                   
                    i++;
                }
                return string.Empty;
            }
            
            else
            {
                return string.Empty;
            }
           
#pragma warning restore

        }
    }
}
