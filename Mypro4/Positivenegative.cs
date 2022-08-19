using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Positivenegative
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("Number is negative");

            }
        }
    }
}
