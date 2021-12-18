using System;

namespace Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=10;
            for(int i=0;i<=n;i++)
            {
                Console.WriteLine("i value is"+ i);
               for(int j=1;j<=n;j++)
                {
                    Console.WriteLine(j);
                }
            }

        }
    }
}
