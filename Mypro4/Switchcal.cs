using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Switchcal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 2 number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("press A=Add B= Subtract C=multiplication D=Division");
            Console.WriteLine("enter Your choice");
            char  choice = char.Parse (Console.ReadLine());
            switch (choice)
            {
                case 'A':
                    Console.WriteLine("Result:" + (a + b));
                    break;
                case 'B':
                    Console.WriteLine("Result:" + (a - b));
                    break;

                case 'C':
                    Console.WriteLine("Result:" + (a * b));
                    break;

                case 'D':
                    Console.WriteLine("Result:" + (a / b));
                    break;
                default:
                    Console.WriteLine("wrong choice");
                    break;

            }
        }
    }
}
