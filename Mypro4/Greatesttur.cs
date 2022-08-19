using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Greatesttur
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter the 1st num");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the 2nd num");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd num");
            int num3 = int.Parse(Console.ReadLine());

            int temp = num1 > num2 ? num1 : num2;
            int max = num3 > temp ? num3 : temp;
            Console.WriteLine("gretest number is"+max);
        }
    }
}
