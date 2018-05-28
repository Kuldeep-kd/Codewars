using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoleculeToAtom
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = "K4[ON(SO3)2]2";
            Console.Write(f.Split('(', ')')[1]);
            Console.ReadKey();
        }


        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            var ans = new Dictionary<string, int>();
            var molecules = new List<char>();

            //                                                               K4[ON(SO3)2]2
            while (formula == "")
            {
                string x = formula.Split('(', ')')[1];
                if(char.IsLetter(x.First()) && char.IsDigit(x.ElementAt(1)))
                {
                    ans.Add(x.First().ToString(), x.ElementAt(1));
                    
                }




            }



            /*
            foreach (char c in formula)
            {
                if (char.IsLetter(c))
                {
                    if (!ans.ContainsKey(c.ToString()))
                    { ans.Add(c.ToString(), 1); }

                    

                    
                }
                endloop:;
            }
            

            */
            

            return ans;
        }



    }
}
