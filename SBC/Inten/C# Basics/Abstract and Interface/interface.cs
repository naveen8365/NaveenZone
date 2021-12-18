using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_and_Interface
{
    interface prgm2
    {
        void sub(int a,int b);
    }
    class prgm3:prgm2
    {
       public void sub(int a,int b)
       {
            Console.WriteLine(a - b);
       }
    }
    
}
