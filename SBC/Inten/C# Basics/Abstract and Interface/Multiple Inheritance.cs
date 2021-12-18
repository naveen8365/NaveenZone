using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_and_Interface
{
    //interface1
    interface inter1
    {
        void multi(int a, int b);
    }
    //parent1
    class parent1:inter1
    {
        public void multi(int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }
    //interface2
    interface inter2
    {
        void multi(int a, int b);
    }
    //parent2
    class parent2:inter2
    {
        public void multi(int a,int b)
        {
            Console.WriteLine(a * b);
        }
    }
    //child
    class child : inter1,inter2
    {
        parent1 obj1 = new parent1();
        parent2 obj2 = new parent2();
        public void multi(int a,int b)
        {
            obj1.multi(a,b);
            obj2.multi(a,b);
        }
    }
}
