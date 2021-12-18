using System;
using System.Collections.Generic;
using System.Text;

namespace Progm
{
    static class Variables
    {
        public static void Add()
        {
            /*   int n1 = Convert.ToInt32(Console.ReadLine());
               int n2 = Convert.ToInt32(Console.ReadLine());

               int num = n1 + n2;
               Console.WriteLine(num.ToString());  */

            

            Console.WriteLine("Even Numbers :");
            for (int i = 1; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\nOdd Numbers :");
            for (int  i = 1; i <= 30; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

           
        }


    }
}

