using System;

namespace Vigenere
{
    class Program
    {
        static void Main(string[] args)
        {
            VigenereEncoder v = new VigenereEncoder();

            Console.WriteLine("Encode (e) or Decode(d)?");
            ConsoleKey key = Console.ReadKey().Key;

            if(key != ConsoleKey.E && key != ConsoleKey.D){
                throw new ApplicationException("Unknown choice");
            }

            Console.WriteLine("");
            Console.WriteLine("Enter keyword and press enter (caps only):");
            string keyword = Console.ReadLine();
            Console.WriteLine("Enter message and press enter (caps only):");
            string message = Console.ReadLine();
            
            if(key.Equals(ConsoleKey.E))
            {
                Console.WriteLine(v.Encrypt(message, keyword));
            } 
            else if(key.Equals(ConsoleKey.D))
            {
                Console.WriteLine(v.Decrypt(message, keyword));
            }
        }
    }
}
