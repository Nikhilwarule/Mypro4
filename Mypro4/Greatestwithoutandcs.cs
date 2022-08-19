using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Greatestwithoutandcs
    {
        static void Main(string[] args)
        {

            int a, b, c;

            Console.WriteLine(" enter the first num");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the sec num");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the thir num");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {


                    Console.WriteLine(a + " greatest");
                }

                else
                {
                    Console.WriteLine(c + " greatest");
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine(b + " gretest");

                }
                else
                {
                    Console.WriteLine(c + " gretest");
                }
            }
        }
    }
}
