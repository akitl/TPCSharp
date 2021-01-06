using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1("test");

            Console.WriteLine(a.Name);
            a.i = 2;
            a.Name = "ok";
            F(a);
            Console.WriteLine(a.Name);

            a.Cris();

            int i = 0;
            S(ref i);
            Console.WriteLine(i);

            Console.ReadLine();

        }

        public static void F(Class1 c) 
        {
            Class1 cc = new Class1(c);
            cc.Name = "non";
            c.Name = "non";
        }

        public static void S(ref int i)
        {
            i = 5;
        }

    }
}
