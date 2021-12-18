using System;

namespace Abstract_and_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //abstract class
            prgm1 pg = new prgm1();
            pg.add(a, b);
            //interface
            prgm3 p = new prgm3();
            p.sub(a, b);
            //multiple inheritance
            child ch = new child();
            ch.multi(a,b);
        }
    }
}
