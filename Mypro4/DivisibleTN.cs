using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class DivisibleTN
    {
        static void Main(string[] args)
        {
            int a = 30;
            Console.WriteLine("Enter the Number");

            int num = int.Parse(Console.ReadLine());
            if (a % 3 == 0 && a % 9 == 0) 
            {
                Console.WriteLine("Number is divisible by 3 and 9" + a);

            }
            else
            {
                Console.WriteLine(" Number is not divisible by 3 and 9" + a);
                ;
            }
        }
    }
}
