using System;

namespace CallbyValue
{
    class Program
    {
        public static void callbyvalue(int n)
        {
            n = n * n;
            Console.WriteLine(n);
        }
        public static void callbyReference(ref int n)
        {
            n = n * n;
            Console.WriteLine(n);
        }
        static void Main(string[] args)
        {
            int n= 40;
            Console.WriteLine(n);
          //  callbyvalue(n);
            callbyReference(ref n);
            Console.WriteLine(n);
        }
    }

    
}
