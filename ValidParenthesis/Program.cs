using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValidParenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidParentheses(""));
            Console.ReadKey();
        }

        public static bool ValidParentheses(string braces)
        {
            /*---------------------------------
            int f = 0, l = 0;
            foreach (char a in braces)
            {
                if (a == '(')
                    f += 1;
                if (a == ')')
                    l += 1;
            }

            if (braces.First() == ')')
                return false;

            if (f == l)
                return true;

            return false;
            ---------------------------------*/
            while (braces.Contains("()") == true || braces.Contains("[]") == true || braces.Contains("{}") == true)
            {
                braces = braces.Replace("()", "");
                braces = braces.Replace("{}", "");
                braces = braces.Replace("[]", "");
            }

            if (braces == "")
                return true;

            return false;
        }
    }
}
