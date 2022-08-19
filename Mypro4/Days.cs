using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Days
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");

            int  choice = int .Parse(Console.ReadLine());

            switch (choice )
            {
                case 1:
                    Console.WriteLine("sun");
                    break;

                case 2:
                    Console.WriteLine("mon" );
                    break;

                case 3:
                    Console.WriteLine("tue" );
                    break;
                case 4:
                    Console.WriteLine("wed" );
                    break;

                case 5:
                    Console.WriteLine("thus" );
                    break;

                case 6:
                    Console.WriteLine("fri");
                    break;
                case 7:
                    Console.WriteLine("sat" );
                    break;
                default: 
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
    }
}
