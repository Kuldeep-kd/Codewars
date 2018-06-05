using System;
using System.Linq;

namespace Cipher_Text
{
    class Cipher
    {
        public class Encode
        {
            public string Ceaser(string hello, int shift)
            {

                string cipher = "";
                int x = 0;
                foreach (char c in hello)
                {
                    x = (( (char.IsUpper(c))?  c  : char.ToUpper(c) ) + shift) % 26;

                    cipher += (char.IsUpper(c)) ? (char)(x + 65) : (char)(x + 97);
                }
                return cipher;
            }

            public string Vigenere(string str, string Key)
            {
                int keyflag = 0, key, r;
                string ans = "";
                char[] keyarr = Key.ToArray();

                foreach (char c in str)
                {

                    if (!char.IsLetter(c))
                        ans += c.ToString();


                    if (keyflag < keyarr.Length && char.IsLetter(c))
                    {
                        key = ((int)keyarr[keyflag]) % 26;

                        if (!char.IsUpper(c))
                            r = ((int)char.ToUpper(c) + key) % 26;
                        else
                            r = ((int)c + key) % 26;

                        ans += (char.IsUpper(c)) ? (char)(r + 65) : (char)(r + 97);

                        keyflag++;
                    }
                    if (!(keyflag < keyarr.Length))
                    {
                        keyflag = 0;
                    }
                }
                return ans;
            }
        }


        public class Decode
        {

            public string Ceaser(string str,int key)
            {
                string ans="";
                int x;
                foreach (char c in str)
                {
                    x = (((char.IsUpper(c)) ? c : char.ToUpper(c)) - key) % 26;
                    ans += (char.IsUpper(c)) ? (char)(x + 65) : (char)(x + 97);
                }

                return ans;
            }





        }
    }
}
