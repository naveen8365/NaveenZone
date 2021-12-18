using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_and_Interface
{
    public abstract class prgm
    {
        public abstract void add(int a,int b);
        public void sub(int n1, int n2)
        {

        }
    }

    class prgm1 : prgm
    {
        public override void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
    }


}
