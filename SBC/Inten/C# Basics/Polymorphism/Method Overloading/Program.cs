using System;
namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string str = Console.ReadLine();

            Prgm.add(a,b);
            Prgm.add(a,b,str);
        }
    }
    class Prgm
    {
        //static method
        public static void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        
        public static void add(int a,int b,string str)
        {
            Console.WriteLine(str+a+b);
        }
    }
}
