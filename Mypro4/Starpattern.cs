using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Starpattern
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 1 || r == 5)
                        Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
    class Ipat
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 5 || r == 1 || r == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }


                Console.WriteLine();
            }
        }
    }
    class Lpat
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {


                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Epat
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 1 || r == 5 || r == 10)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class Tpat
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 5 || r == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");

                }
                Console.WriteLine();
            }
        }
    }
    class Ppatt
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 5 || r == 1 || (c == 10 && r <= 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
    class zeropat
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || c == 10 || r == 10 || r == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
    class Fpat
    {
        static void Main(string[] args)
        {

            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == 1 || r == 1 || r == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }

        }
    }
    class Xpat
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 10; c++)
                {
                    if (c == r || r + c == 11)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
    class Star
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
    class star2
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r++)
            {
                for (int c = 1; c <= r; c--)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }
    class Star3
    {
        static void Main(string[] args)
        {
            for (int r = 6; r <= 9; r++)
            {
                for (int c = 6; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
    class Fa
    {
        static void Main(string[] args)
        {
            for ( char  r='A';r<='F';r++)
            {
                for (char  c='F';c>=r;c-- )
                {
                    Console.Write( c );
                }
                Console.WriteLine();
            }
        }
    }
    class Star4
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c >= 1; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
    class Star5
    {
        static void Main(string[] args)
        {
            for (int r = 5; r >= 1; r--)
            {
                for (int c = r; c >= 1; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }


    class Star6
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = r; c >= 1; c--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }

    class Startri
    {
        static void Main(string[] args)
        {
            int even = 2;

            for (int r = 1; r <= 9; r++)
            {
                for (int c = r; c <= 5; c++)
                {
                    Console.Write(c);
                }
                if (r >= 6)

                {
                    for (int c1 = r - even; c1 <= 5; c1++)
                    {
                        Console.Write(c1);
                    }
                    even = even + 2;
                }
                Console.WriteLine();
            }
        }
    }
    /*class Staralpha
    {
        static void Main(string[] args)
        {
            int even = 2;

            for (char, int  r = A; r <= 9; r++)
            {
                for (char  c = r; c <= F; c++)
                {
                    Console.Write(c);
                }
                if (r >= 6)

                {
                    for (int c1 = r - even; c1 <= F; c1++)
                    {
                        Console.Write(c1);
                    }
                    even = even + 2;
                }
                Console.WriteLine();
            }
        }
    }*/
    class Star10
    {
        static void Main(string[] args)
        {
            for (char r = 'E'; r >= 'A'; r--)
            {
                for (char c = 'A'; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
    class Star11
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c % 2);
                }
                Console.WriteLine();

            }
            int k = 0;
            for (int r = 1; r < 4; r++)
            {
                for (int c = 1; c < r; c++)
                {
                    Console.Write(k);
                    k++;

                }
                Console.WriteLine();
            }
        }
    }
    class statri
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 10; r = r + 2)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
    class trianglestar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of lines");
            int line = int.Parse(Console.ReadLine());
            for (int i = 1; i <= line; i++)
            {
                for (int j = 1; j < 2 * i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
    class Pyrmid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number of lines");
            int line = int.Parse(Console.ReadLine());
            for (int r = 1; r <= line; r++)
            {
                for (int sp = 1; sp <= line - r; sp++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < 2 * r; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
        }
    }
    class numpyramid
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int sp = r; sp <= 4; sp++)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                for (int k = r - 1; k >= 1; k--)
                {
                    Console.Write(k);
                }
                Console.WriteLine();


            }
        }
    }
}
