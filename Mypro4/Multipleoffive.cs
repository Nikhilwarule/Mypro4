using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Multipleoffive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");

            int num = int.Parse(Console.ReadLine());
            /*if (num % 5 == 0)
            {
                Console.WriteLine("the number is multiple of five");
            }
            else
            {
                Console.WriteLine(" the number is not multiple of five");
            }*/

            string mul = num % 5 == 0 ? "multiple of five" : "not multiple of five";

            Console.WriteLine(mul);
        }
    }
}
