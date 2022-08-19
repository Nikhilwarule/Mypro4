using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Turnaryodd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());


            string str = num % 2 == 0 ? "even" : "odd";

            Console.WriteLine(  str );
        }
    }
}
