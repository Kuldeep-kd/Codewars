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
            //Console.Write(f.Split('(', ')')[1]);
            var d = ParseMolecule(f);

            foreach(KeyValuePair<string,int> c in d)
            {
                //Console.WriteLine("Key = {0} , Value = {1}", c.Key, c.Value);
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }

        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            var ans = new Dictionary<string, int>();
            var molecules = new List<char>();
            int temp = 0;
            
            
            while (formula != "")
            {
                string x = formula;//.Split('(', ')')[1];
                
                //      1.
                if (char.IsLetter(x.First()) && char.IsDigit(x.ElementAt(1)))
                        {
                            if (ans.ContainsKey(x.First().ToString()))
                            {
                                temp = x.ElementAt(1) + ans[x.First().ToString()];
                                ans.Add(x.First().ToString(), temp);
                                x = x.Replace(x.First().ToString(), "").Replace(x.First().ToString(),"");
                            }
                            else
                            {
                                ans.Add(x.First().ToString(), int.Parse(x.ElementAt(1).ToString()));
                                x = x.Replace(x.First().ToString(), "");
                                x = x.Replace(x.First().ToString(), "");
                    }
                        }
                //      2.
                else if (char.IsLetter(x.First()) && !char.IsDigit(x.ElementAt(1)))
                        {

                    if (ans.ContainsKey(x.First().ToString()))
                    {
                        temp = 1 + ans[x.First().ToString()];
                        ans.Remove(x.First().ToString());
                        ans.Add(x.First().ToString(), temp);
                        x = x.Replace(x.First().ToString(), "").Replace(x.First().ToString(), "");
                    }
                    else
                    {
                        ans.Add(x.First().ToString(), int.Parse(x.ElementAt(1).ToString()));
                        x = x.Replace(x.First().ToString(), "").Replace(x.First().ToString(), "");
                    }
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
