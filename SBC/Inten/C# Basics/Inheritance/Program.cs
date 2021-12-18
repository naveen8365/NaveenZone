using System;

namespace Inheritance
{
    class Program
    {
       //Single-level inheritance
       //Multi-level inhreritance
       //Multiple inheritance not supported so we use interface
        static void Main(string[] args)
        {


          int n1 = Convert.ToInt32(Console.ReadLine());
          int n2 = Convert.ToInt32(Console.ReadLine());
          prgm3 pg = new prgm3();
            pg.add(n1,n2);
            prgm1.sub(n1,n2);
            pg.multi(n1,n2);
            pg.divide(n1, n2);
        }
    }
    
    class prgm
    {
        //non static method
        public void add(int n1,int n2)
        {
            Console.WriteLine("Addition:"+(n1+n2));
        }
    }
    class prgm1:prgm
    {
        //static method
        public static void sub(int n1,int n2)
        {
            Console.WriteLine("Subtraction:"+(n1-n2));
        }
    }
    class prgm2 : prgm1
    {
        public int multi(int n1,int n2)
        {
            Console.WriteLine("Multiplication:"+(n1*n2));
            return 0;
        }
    }
    class prgm3:prgm2
    {
        //Try catch Exception
        public void divide(int n1,int n2)
        {
            if (n2 > 0)
            {
                Console.WriteLine("Division:" + (n1 / n2));
            }
            else
            {
                try
                {
                    int x = n1 / n2;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("Infinity");
            }
        }
    }
}
