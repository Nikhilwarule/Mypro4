using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Odd
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 299; i >= 200; i = i - 2)
            {
                Console.WriteLine(i);
            }


        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            char ch;
            for (ch = 'a'; ch<= 'z';ch++)
            {
                Console.WriteLine(ch);
            }
        }
    }
    class multi
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 40; i = i + 4)
                Console.WriteLine(i);
        }
    }

    class sq
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int num = i * i;
                Console.WriteLine(num);
            }


        }
    }

    class tablek
    {


        static void Main(string[] args)
        {
            Console.WriteLine(" enter the number ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(n + "X" + i + "==" + n * i);
            }


        }
    }
    class fact
    {
        static void Main(string[] args)
        {
            int mult = 1;
            for (int i = 1; i < 10; i++)
            {
                mult = mult * i;

            }
            Console.WriteLine(  mult);
        }
 
    }
    class factors
    {
        static void Main(string[] args)
        {
            int n = 12;
            for(int i=1;i<=n;i++)
            {
                if(n % i == 0)
                    Console.WriteLine("factors="+i);
            }
        }
    }
    class Prime
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine());
            int c = 0;

            for (int i  = 1; i<= n; i++) 
            {
                if (n % i == 0)
                {
                    Console.WriteLine("factor=" +n  );
                    c++;

                

                }
            }if(c==2)
                Console.WriteLine("prime");
            else 
                Console.WriteLine("Not Prime");
        }
    }
    class Gcds
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int gcd = 0;

            for( int i=1;i<=a;i++)
            {
                if (a%i==0 && b%i==0)
                {
                    gcd = i;

                }    
            }
            Console.WriteLine("gcd"+gcd);
            int lcm = a * b / gcd;
            Console.WriteLine("lcm="+lcm );
        }
    }
    class whilen
    {
        static void Main(string[] args)
        {
            int n = 534;
            int sum = 0;

            while(n>0)
            {
                int last = n % 10;
                sum = sum + last;
                n = n / 10;

            }
            Console.WriteLine(sum );
            Console.WriteLine();
        }
    }
    class Evennum
    {
        static void Main(string[] args)
        {
            int sum = 0, eve = 0, odd = 0;
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                int last = n % 10;
                if (last % 2==0)
                {
                    eve = eve= + 1 ;

                }
                else
                {
                    odd = odd = +1;

                }
                sum = sum + last;
                n = n / 10;

            }
            Console.WriteLine("eve" + eve, "odd" + odd) ; 
        }
                 
    }
    class Neo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int squ = 1;
            int last = 0;
            int n = int.Parse(Console.ReadLine());
            squ = n * n;
            while (squ >10)
            {
                last = squ % 10;
                sum = sum + last;
                squ = squ / 10;

            }
            if(last==n)
            {
                Console.WriteLine("neon num");

            }
            else
            {
                Console.WriteLine("not neon");
            }

        }
    }
    class Pali
    {
        static void Main(string[] args)
        {
            Console.WriteLine(  "enter the number");
            int n = int.Parse(Console.ReadLine());
            int temp = n;
            int reverse = 0;
            while(n>0)
            {
                int l = n % 10;
                reverse = reverse * 10 + l;

                n = n / 10;

            }
            if(reverse==temp )
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("not Palindrome");
        }
    }
}