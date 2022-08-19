using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            if(num % 10==0)
            {
                Console.WriteLine("number is divisible by10");

            }
            else
            {
                Console.WriteLine("number is not divisible by 10");

            }

        }
    }
}
