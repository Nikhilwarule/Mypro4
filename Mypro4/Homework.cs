using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Homework
    {
        static void Main(string[] args)
        {
            int a = 299;
            int b = 521;
            while (a <= b)
            {

                Console.WriteLine(a);
                a = a + 2;

            }
        }
    }
    class Countdecimal
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.WriteLine("enter the num");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int r = num % 10;
                num = num / 10;
                count++;
            }
            Console.WriteLine(count );

        }
    }
    class Fact
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of term");
            int n = int.Parse(Console. ReadLine());

            int fact = 1;
            int sum = 0;
            Console.WriteLine(sum);
            int odd = 1;
            for(int i=1;i<=n;i++)
            {
                fact = 1;
                for (int j=1;j<=odd;j++)
                {
                    fact = fact * j;

                }
                odd = odd + 2;
                sum = sum + fact;
                Console.WriteLine(sum);

            }
        }
    }
    class star3
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 4-r; c >=1; c--)
                {
                    Console.Write(" ");
                }
                for(int c = 1; c <= 2*r -1; c++)
                    {
                        Console.Write( r);
                    }
                Console.WriteLine();
            }
        }
    }
    class Star7
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r ; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();

            }
            for (int r = 2; r <= 5; r++)
            {
                for (int c = 1; c <= r ; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();

            }

        }
    }
    class Penn
    {
        string penname;
        string brand;
        string color;
        int price;
        public Penn()
        {

        }
        public Penn (string pnm)
        {
            penname = pnm;

        }
        public Penn(string pnm,string br,int pr)
        {
            penname = pnm;
            brand = br;
            price = pr;

        }
        public Penn (string pnm,string br,string c,int pr)
        {
            penname = pnm;
            brand = br;
            price = pr;

        }
        class Ptest
        {
            static void Main(string[] args)
            {
                Penn n= new Penn();
                Penn n1= new Penn("cell");
                Penn n2 = new Penn("cello", "ball", 7);
                Penn n3 = new Penn("stylo", "boll pen ", "red", 10);

            }
        }
    }
}

