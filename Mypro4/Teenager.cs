using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Teenager
    {
        static void Main(string[] args)
        {
             Console.WriteLine("enter the age");
            int age = int.Parse(Console.ReadLine());

            /*if (age>13&&age<19)
            {
                Console.WriteLine("He is teenager");
            }
            else
            {
                Console.WriteLine("He is not teenager");
            }*/

            string teenager = age >= 13 && age <=19 ? "teenager" : "no teenager";

            Console.WriteLine(teenager);


        }
    }
}
