using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Oddswitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");


            int num = int.Parse(Console.ReadLine());
          

            switch (num%2==0)
          

            {
              
                case true:

                    Console.WriteLine("even");
                    break;

                case false:

                    Console.WriteLine("odd" );
                    break;

                default:
                    Console.WriteLine("invalid");
                    break;

               
            }

        }
    }
}

