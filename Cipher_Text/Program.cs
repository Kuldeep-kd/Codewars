using System;
using static Cipher_Text.Cipher;

namespace Cipher_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            Encode encode = new Encode();
            Decode decode = new Decode();


            Console.WriteLine(encode.Ceaser("Kul", 2));
            Console.WriteLine(encode.Vigenere("Hello This is Kuldeep....", "PANDA"));
            Console.WriteLine(decode.Ceaser("Zja", 2));
            Console.ReadKey();
            
        }

    }
}
