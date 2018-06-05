using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cipher_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cipher_text1("ABCDEFGHIJKLMN"));
            Console.WriteLine(Cipher_text2("I LIKE YOU","PANDA"));
            Console.ReadKey();
        }

        public static string Cipher_text2(string v1, string v2)
        {
            int keyflag=0,key,r;
            string ans = "";
            char[] keyarr = v2.ToArray();
            foreach(char c in v1)
            {
                if (c == ' ')
                {
                    ans += " ";
                }
                else if (keyflag < keyarr.Length)
                {
                    
                    key = ((int)keyarr[keyflag]) % 26;

                    r = ((int)c + key) % 26;

                    ans += (char)(r + 65);
                    keyflag++;
                }
                else
                    keyflag = 0;

                
            }


            return ans;
        }

        public static string Cipher_text1(string hello)
        {
            string cipher="";
            int x=0;

            foreach( char c in hello)
            {
                x = (Convert.ToInt32(c) + 2 ) % 26;
                //Console.WriteLine((char)(x+65));
                cipher += ((char)(x + 65));
            }

            return cipher;
        }

    }
}
