using System;

namespace Cipher_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Cipher cipher = new Cipher();

            Console.WriteLine(cipher.Cipher_Ceaser("ABCDEFGHIJKLMN", 3));
            Console.WriteLine(cipher.Cipher_Vigenere("Hello This is Kuldeep....", "PANDA"));
            Console.ReadKey();
        }

    }
}
