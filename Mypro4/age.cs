using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class age
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the your age");
            int your = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the friend age ");
            int friend = int.Parse(Console.ReadLine());

            /*if(friend<your)
            {
                Console.WriteLine("Hi");
            }
            else if(friend >your)
            {
                Console.WriteLine("good morning");
            }
            else
            {
                Console.WriteLine("how are you");
            }*/

            string result= friend<your?"hi":(friend>your?"good morning" :"how are you");
            Console.WriteLine(result);
        }
    }
}
