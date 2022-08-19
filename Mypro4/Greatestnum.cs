using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Greatestnum
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

            if (a > b && a > c)
            {
                Console.WriteLine(a + " greatest");

            }
            else if (b > a && b > c)
            { 
                Console.WriteLine(b + " greatest"); 
            }
            else if (c>a&&c>b)
            {
                Console.WriteLine(c + " gretest");

            }
                
            else
            {
                Console.WriteLine("All constant");

            }

            

            

            
        }
    }
}
