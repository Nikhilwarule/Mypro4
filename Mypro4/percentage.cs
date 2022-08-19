using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class percentage
    {
        static void Main(string[] args)
        {
            int english, bio, math, marathi, hindi;
            double per;

            Console.WriteLine("enter the marks of english");

            english = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marksof bio");

            bio = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marksof math");

            math  = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marksof marathi");

            marathi = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the marksof hindi");

            hindi  = int.Parse(Console.ReadLine());

            per = ((english + bio + math + marathi + hindi) / 500.00) * 100;

            Console.WriteLine("the total marks of "+per );

            if (per >60&&per<75)
            {
                Console.WriteLine("grade is first class");

            }
            if(per>75)
            {
                Console.WriteLine("grade is distinction");
               
            }
            if(per<60&&per<35)
            {
                Console.WriteLine("grade is pass");

            }
            else if (per<35)
            {
                Console.WriteLine("failed");
            }

        }
    }
}
