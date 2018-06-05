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


            Console.WriteLine("Encode Ceaser : " + encode.Ceaser(Console.ReadLine(), 2));
            Console.WriteLine("Encode Vignere : " + encode.Vigenere("Kuldeep", "Panda"));
            Console.WriteLine("Decoding \n1. Ceaser\n2. Vignere\n");
            Console.WriteLine("Decode Ceaser : " + decode.Ceaser(Console.ReadLine(), 2));
            Console.WriteLine("Decode Vignere : " + decode.Vigenere(Console.ReadLine(), Console.ReadLine()));
            Console.ReadKey();
            
        }

    }
}
