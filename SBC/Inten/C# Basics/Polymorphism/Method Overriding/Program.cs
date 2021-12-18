using System;

namespace Method_Overriding
{
    //class
    class Program    
    {
        static void Main(string[] args)
        {
            //User input
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            //Creating object 
            prgm1 pg = new prgm1();
            pg.add(a,b);
        }
    }
    //Parent or base class
    class prgm
    {
        //Method
        public virtual int add(int a,int b) 
        {
            Console.WriteLine(a + b);
            //return type
            return 0;
        }
    }
    //Child or derived class
    class prgm1 : prgm
    {
        public override int add(int a,int b)
        {
            Console.WriteLine(a - b);
            return 0;
        }
    }
}
