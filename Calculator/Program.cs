using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Evaluate("2 +9-6*1/9"));
            Console.ReadKey();

        }


        public static double Evaluate(string expression)
        {
            
            List<int> lst = new List<int>();
            List<string> operation = new List<string>();
            expression = expression.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("{", "").Replace("}", "").Replace("[", "").Replace("]", "");



            Regex num = new Regex(@"\d+");
            Match m = num.Match(expression);

            while (m.Success)
            {
                lst.Add(Convert.ToInt32(m.Value));
                m = m.NextMatch();
            }
            double answer = lst[0];

            Regex syms = new Regex(@"\W");
            Match smatch = syms.Match(expression);

            while(smatch.Success)
            {
                operation.Add(smatch.Value);
                smatch = smatch.NextMatch();
            }
            int i = 1;
            //while()
            {
              foreach(string s in operation)
                {
                    if (s == "+")
                        answer += lst.ElementAt(i);

                    if (s == "-")
                        answer -= lst.ElementAt(i);

                    if (s == "*")
                        answer *= lst.ElementAt(i);

                    if (s == "/")
                        answer /= lst.ElementAt(i);

                    i++;
                }
            }


            return answer;
        }
           
        public static void funcc()
        {
            
        }
        
    }


}
