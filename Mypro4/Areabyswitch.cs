using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Areabyswitch
    {
        static void Main(string[] args)
        {

            Console.WriteLine(  "1 .area of circle");
            Console.WriteLine("2. area of rectangle");
            Console.WriteLine("3. area of square");
            Console.WriteLine("4. area of triangle");
            Console.WriteLine(" Input your choice : ");


          

            int  choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case '1':
                    Console.WriteLine("Input radius of the circle : ");
                   int  r = Convert.ToInt32(Console.ReadLine());
                  float   A = 3.14f * r * r;
                    Console.WriteLine("area of circle="+A );
             
                    break;

                case '2':
                    Console.Write("Input length  of the rectangle : ");
                   int  l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                   int  w = Convert.ToInt32(Console.ReadLine());
                   int  R = l * w;
                    Console.WriteLine("area of rectangle=" + R );
                    break;

                case '3':
                    Console.WriteLine("Input areaf square : ");
                   int  a = Convert.ToInt32(Console.ReadLine());
                   int  C = a * a;
                    Console.WriteLine("area of square=" + C);
                    break;

                case '4':
                    Console.Write("Input the base of the triangle :");
                int     b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                   int  h = Convert.ToInt32(Console.ReadLine());
                 float     T  = 0.5f * b * h;
                    Console.WriteLine("area of triangle" + T);

                    break;
                default: Console.WriteLine("invalid statement=");
                    break;


                
                    

            }
            
        }
    }
}
