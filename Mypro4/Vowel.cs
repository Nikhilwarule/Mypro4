using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the charachter");

            char ch = char.Parse(Console.ReadLine());
            if (ch == 'a' || ch == 'A')
            {
                Console.WriteLine("it is vowel");

            }
            else if (ch == 'e' || ch == 'E')
            {
                Console.WriteLine("it is vowel");

            }
            else if (ch == 'i' || ch == 'I')
            {
                Console.WriteLine("it is vowel");

            }
            else if (ch == 'o' || ch == 'O')
            {
                Console.WriteLine("it is vowel");

            }
            else if (ch == 'u' || ch == 'U')
            {
                Console.WriteLine("it is vowel");

            }
            else
                Console.WriteLine(" it is consanant");


        }
    }
}
