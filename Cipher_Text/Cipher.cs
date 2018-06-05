using System;
using System.Linq;

namespace Cipher_Text
{
    class Cipher
    {
        public string Cipher_Ceaser(string hello, int shift)
        {

            string cipher = "";
            int x = 0;
            foreach (char c in hello)
            {
                x = (Convert.ToInt32(c) + shift) % 26;
                //Console.WriteLine((char)(x+65));
                cipher += ((char)(x + 65));
            }
            return cipher;
        }

        public string Cipher_Vigenere(string str, string Key)
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
}
