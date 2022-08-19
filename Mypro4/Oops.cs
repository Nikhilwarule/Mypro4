using System;
using System.Collections.Generic;
using System.Text;

namespace Mypro4
{
    class Oops
    {
        string name;
        int percent;
        int passoutyear;
        string branch;
        string technicalskills;

        static void Main(string[] args)
        {
            int x = 90;

            Oops s1 = new Oops();
            s1.name = "Jyoti";
            s1.percent = 90;
            s1.passoutyear = 2021;
            s1.branch = "computer";
            s1.technicalskills = " Csharp";

            Oops s2 = new Oops();
            s1.name = "Nikhil";
            s1.percent = 76;
            s1.passoutyear = 2020;
            s1.branch = "I&c";
            s1.technicalskills = " Dotnet";


        }
    }
    class Studentifo
    {
        string name;
        int percent;
        int passoutyear;
        string branch;
        string technicalskill;

        public void accept()
        {
            Console.WriteLine("enter name,percent,passoutyear,branch,technicalskill");

            name = Console.ReadLine();
            percent = int.Parse(Console.ReadLine());
            passoutyear = int.Parse(Console.ReadLine());
            branch = Console.ReadLine();
            technicalskill = Console.ReadLine();

        }
        public void display()
        {
            Console.WriteLine("name" + name);
            Console.WriteLine("Percentage" + percent);
            Console.WriteLine("pass out year" + passoutyear);
            Console.WriteLine("branch" + branch);
            Console.WriteLine("technicalskill" + technicalskill);
        }

    }


    class Ttest
    {
        static void Main(string[] args)
        {
            Studentifo s1 = new Studentifo();

            s1.accept();
            s1.display();

            Studentifo s2 = new Studentifo();

            s2.accept();
            s2.display();
        }
    }

    class Cally
    {
        int n1, n2;
        public void accept()
        {
            Console.WriteLine("enter num");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
        }


        public void add()
        {
            int sum = n1 + n2;
            Console.WriteLine("sum" + sum);
        }


        public int multi()
        {
            int mul = n1 * n2;
            return mul;


        }
        public float divide()

        {
            float div = n1 % n2;
            return div;
        }
        public int sub()
        {
            int sub = n1 - n2;
            return sub;
        }
    }
    class Cal
    {
        static void Main(string[] args)
        {
            Cally c = new Cally();
            c.accept();

            c.add();
            int k = c.multi();
            int s = c.sub();
            float d = c.divide();
            Console.WriteLine(k + "" + s + "" + d);

        }
    }
    class fac
    {
        int a;
        public void accept()
        {
            Console.WriteLine("enter a number");
            a = int.Parse(Console.ReadLine());

        }
        public int factorial()
        {
            int f = 1;
            for (int i = 1; i <= a; i++)
            {
                f = f * i;


            }
            return f;

        }
        public bool nopri()

        {
            int count = 0;
            bool result = false;
            for (int j = 1; j <= a; j++)
            {
                if (a % j == 0)
                {
                    count++;

                }

            }
            if (count == 2)
            {
                result = true;

            }
            else
                result = false;

            return result;
        }
    }
    class fact1
    {
        static void Main(string[] args)
        {
            fac c = new fac();
            c.accept();
            int f = c.factorial();
            bool result = c.nopri();


            Console.WriteLine("factorial" + f);
            Console.WriteLine(result == true ? "prime" : "not prime");
        }
    }
    /*static variables started*/
    class Hdfcbank
    {
        int accid;
        string accnm;
        int bal;
        static float roi = 7.8f;

        public void m1()
        {
            int a = 90;

        }
        /*static not require object*/
        static void m2()
        {

        }
        static void Main(string[] args)
        {
            Hdfcbank h1 = new Hdfcbank();
            h1.m1();
            h1.accid = 900;
            Hdfcbank.m2();
            Console.WriteLine("Hello");
            Console.WriteLine(Hdfcbank.roi);
        }
    }

    class Movie2
    {
        string moviename;
        int rating;
        public void setMoviename(string nm)
        {
            moviename = nm;

        }
        public string getMoviename()
        {
            return moviename;

        }
        public void setRating(int r)
        {
            rating = r;

        }
        public int getRating()
        {
            return rating;

        }


    }
    class MTest
    {
        static void Main(string[] args)
        {
            Movie2 m1 = new Movie2();
            m1.setMoviename("ready");
            Console.WriteLine(m1.getMoviename());
        }
    }

    class restaurantnamee
    {
        string restaurantname;
        string area;
        long mobilename;
        int rating;


        public string RestaurantName
        {
            set { restaurantname = value; }
            get { return restaurantname; }
        }
        public int Rating
        {
            set { rating = value; }
            get { return rating; }
        }
        public long MobileName
        {
            set { MobileName = value; }
            get { return MobileName; }
        }
        public string Area
        {
            set { Area = value; }
            get { return Area; }
        }
    }
    class Rtest
    {
        static void Main(string[] args)
        {
            {
                restaurantnamee r = new restaurantnamee();
                r.RestaurantName = "Swagat";
                Console.WriteLine(r.RestaurantName);
                r.Rating = 4;
                Console.WriteLine(r.Rating);
                Console.WriteLine("Enter mobile name");
                r.MobileName = long.Parse(Console.ReadLine());
                Console.WriteLine(r.MobileName);
                r.Area = "Jalgaon";
                Console.WriteLine(r.Area);

            }
        }
    }
    class Timee
    {
        double hour;
        double minute;
        double second;
        public Timee()
        {
            Console.WriteLine("default constructor");
        }


        public double Hour
        {
            set { hour = value; }
            get { return hour; }
        }
        public double Minute
        {
            set { minute = value; }
            get { return minute; }
        }
        public double Second
        {
            set { second = value; }
            get { return second; }
        }
    }
    class timing1
    {
        static void Main(string[] args)
        {
            {
                Timee t1 = new Timee();
                t1.Hour = 1;
                Console.WriteLine(t1.Hour);
                t1.Minute = 60;
                Console.WriteLine(t1.Minute);
                t1.Second = 3600;
                Console.WriteLine(t1.Second);



            }
        }
    }
    class Rectangle
    {
        int length;
        int breadth;
        int area;
        int perimeter;
        public Rectangle()
        {
            Console.WriteLine("Default Construtor");
        }

        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public int Breadth
        {
            set { breadth = value; }
            get { return breadth; }
        }
        public int Area()
        {
            area = length * breadth;
            return area;

        }
        public int Perimeter()
        {
            perimeter = 2 * (length + breadth);
            return perimeter;
        }

    }
    class rect1
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("Enter length");
            r1.Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            r1.Breadth = int.Parse(Console.ReadLine());

            Console.WriteLine("Are=" + r1.Area());
            Console.WriteLine("Perimeter=" + r1.Perimeter());

        }
    }
    class Calculatorr
    {
        int A, B, result;
        public int a
        {
            set { a = value; }
            get { return a; }
        }
        public int b
        {
            set { b = value; }
            get { return b; }
        }
        public void Add()
        {
            result = a + b;
            Console.WriteLine("Addition" + result);
        }
        public void Sub()
        {
            result = a - b;
            Console.WriteLine("Subtraction" + result);
        }
        public void Mul()
        {
            result = a * b;
            Console.WriteLine("Multiplication" + result);
        }
        public void Div()
        {
            result = a / b;
            Console.WriteLine("Division" + result);
        }
    }
    class Cc
    {
        static void Main(string[] args)
        {
            Calculatorr c1 = new Calculatorr();
            Console.WriteLine("Enter value of A");
            c1.a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of B");
            c1.b = int.Parse(Console.ReadLine());

            c1.Add();
            c1.Sub();
            c1.Mul();
            c1.Div();

        }


    }

    class Over
    {
        static void max(int a, int b)

        {

            Console.WriteLine("Enter the two num");


            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("max" + a);
            else
                Console.WriteLine("max" + b);

        }
        static void max(int a, int b, int c)
        {
            Console.WriteLine("Enter three num");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine("max:" + a);
            if (b > a && b > c)
                Console.WriteLine("max:" + b);
            else
                Console.WriteLine("max:" + c);
        }
        static void Main(string[] args)
        {

            max(4, 2);
            max(3, 7, 6);




        }

    }




    class Pen
    {
        string penname;
        string brand;
        string color;
        int price;
        public Pen()
        {

        }
        public Pen(string pnm)
        {
            penname = pnm;
        }


        public Pen(string pnm, string br, int pr)
        {
            penname = pnm;
            brand = br;
            price = pr;
        }
        public Pen(string pnm, string br, string c, int pr)
        {
            penname = pnm;
            brand = br;
            price = pr;
        }
        class penTest
        {
            static void Main(string[] args)
            {
                Pen p = new Pen();
                Pen p1 = new Pen("cello");
                Pen p2 = new Pen("cello", "jell", 30);
                Pen p3 = new Pen(" stylo", "bollpen", "red", 10);
            }
        }



        class Pencil
        {
            string pname;
            int cost;
            static int c;
            static Pencil()
            {
                c = 900;
                Console.WriteLine("in static constructor");


            }
            public Pencil()
            {

            }
            Pencil(string pname, int cost)
            {
                this.pname = pname;
                this.cost = cost;

            }
            /*instance method*/
            public void m1()
            {
                Console.WriteLine("in m1");
            }
            static void Main(string[] args)
            {
                Console.WriteLine("in main starts");
            }
        }
    }
    class P
    {
        int id = 101;
        string nm = "om";

        public int Id1 { get => id; set => id = value; }
        public string Nm1 { get => nm; set => nm = value; }
        public void m1()
        {
            Console.WriteLine("in parent m1");

        }
    }
    class child : P
    {
        public void m2()
        {
            Console.WriteLine("in child m2");
        }
    }

    class childy : child
    {
        public void m3()
        {
            Console.WriteLine("in child m3");
        }
    }
    class Inherit
    {
        static void Main(string[] args)
        {
            {
                childy c = new childy();
                c.m1();
                c.m2();
                c.m3();
                Console.WriteLine(c.Id1);
                Console.WriteLine(c.Nm1);
            }
        }
    }
    class Teacher
    {
        string tname;
        int salary;
        int experience;
        public Teacher()
        {
            Console.WriteLine("in teacher constructor");
        }

        public Teacher(string tname, int salary, int experience)
        {
            this.tname = tname;
            this.salary = salary;
            this.experience = experience;
        }

        public string Tname { get => tname; set => tname = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Experience { get => experience; set => experience = value; }
    }
    class VisitingTeacher : Teacher
    {
        int hrs, rates;
        public VisitingTeacher(string nm, int sal, int exp, int hrs, int r) : base(nm, sal, exp)
        {
            Console.WriteLine("in visiting teacher constructor");
            this.Hrs = hrs;
            this.Rates = r;
        }

        public int Hrs { get => hrs; set => hrs = value; }
        public int Rates { get => rates; set => rates = value; }
    }
    class VTt
    {
        static void Main(string[] args)
        {
            VisitingTeacher v = new VisitingTeacher("Nikk", 15, 1000, 8, 500);
            Console.WriteLine(v.Salary);
            Console.WriteLine(v.Experience);
            Console.WriteLine(v.Tname);
        }
    }
    class pen
    {
        string brand;
        int cost;
        string color;

        public pen(string brand, int cost, string color)
        {
            this.Brand = brand;
            this.Cost = cost;
            this.Color = color;

        }

        public string Brand { get => brand; set => brand = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Color { get => color; set => color = value; }

    }
    class CompossBox
    {
        string compass_brand;
        int price;
        Pen pen;
        static void Main(string[] args)
        {
            CompossBox box = new CompossBox();
            box.compass_brand = "apsara";
            box.price = 200;
            Console.WriteLine(box.compass_brand);
            Console.WriteLine(box.price);
            box.pen = new Pen("Trimax", "Red", 60);
            Console.WriteLine(box.pen);

        }

    }

    class Customer
    {
        string name;
        long mo;

        public Customer(string name, long mo)
        {
            this.name = name;
            this.mo = mo;
            Console.WriteLine(name);
        }




        public string Name
        {
            set => name = value;
            get => name;
        }
        public long Mo
        {
            set => mo = value;
            get => mo;

        }
    }
    class Item
    {
        string itemname;
        int itemprice;
        int quantity;

        public Item(string itemname, int itemprice, int quantity)
        {
            this.itemname = itemname;
            this.itemprice = itemprice;
            this.quantity = quantity;
        }

        public string Itemname { get => itemname; set => itemname = value; }
        public int Itemprice { get => itemprice; set => itemprice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
    class Order
    {
        int orderid;
        int odate;
        Customer cust;
        Item item;

        public int Orderid { get => orderid; set => orderid = value; }
        public int Odate { get => odate; set => odate = value; }

        static void Main(string[] args)
        {
            Order r = new Order();
            r.orderid = 222;
            r.odate = 5 / 1 / 2022;
            r.cust = new Customer("Nik", 9960695900);
            r.item = new Item("Mobile", 35000, 1);
            Console.WriteLine(r.cust.Name);

        }
    }
    class parent
    {
        string name;
        public void play()
        {
            Console.WriteLine("play on ground");
        }
        public virtual void study()
        {
            Console.WriteLine("Read books");
        }
    }
    class Child : parent
    {
        public override void study()
        {
            Console.WriteLine("Learn watching online videos");
        }

    }
    class TTest
    {
        static void Main(string[] args)
        {
            parent p = new parent();
            p.study();
            Child c1 = new Child();
            c1.study();

            parent p2 = new Child();
            p2.study();
        }
    }
    class aaa
    {
        public void add(int a, int b)
        {

        }
        public void add(int a, int b, int c)
        {

        }
    }
    class Parent
    {
        string name;
        public void play()
        {
            Console.WriteLine("play on ground");
        }

        public virtual void study()
        {
            Console.WriteLine("Read books");
        }
        public static void m1()
        {
            Console.WriteLine("in parent");
        }
    }

    class Child6 : Parent
    {
        public static void m1()
        {
            Console.WriteLine("in child m1");
        }
        public new void play()
        {
            Console.WriteLine("play videos games");
        }
        public override void study()
        {
            Console.WriteLine("Learn watching online videos");
        }
        static void Main(int a)
        {

        }
    }
    class Mtt
    {
        static void Main(string[] args)
        {
            // Child6.m1();
            Parent p = new Child6();
            p.play();
        }
    }

    class PPPP
    {
        public virtual void m1()
        {
            Console.WriteLine("in parent m1");
        }
    }
    class CC1 : PPPP
    {
        public sealed override void m1()
        {
            Console.WriteLine("in child m1");
        }
    }
    class CC2 : CC1
    {
        public virtual void m1()
        {
            Console.WriteLine(" in child2222222 m1");
        }

        static void Main(string[] args)
        {
            PPPP ob = new CC2();

            ob.m1();

        }
    }
    class Cand
    {
        int sid;
        string name;
        int percent;
        public Cand (int sid, string name, int percent)
        {
            this.sid = sid;
            this.name = name;
            this.percent = percent;

        }
        public override string ToString()
        {
            return $"Sid:{sid} Name:{name }Percentage:{percent}";
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);
            Cand s1 = new Cand(1,"Nik", 70);
            Console.WriteLine(s1);
        }
    }

}



