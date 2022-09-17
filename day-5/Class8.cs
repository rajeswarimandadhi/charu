using System;
using System.Collections.Generic;
using System.Text;

namespace day_5
{

    class SampelA
    {
        public virtual void show()
        {
            Console.WriteLine("Hi I am from base");
        }
        public void print()
           
        {
            Console.WriteLine("Hi I am from print base");
        }
    }
    class SampelB : SampelA
    {
        public override void show()
        {
            Console.WriteLine("Hi I am from Derived");
        }
        public void print()
        
        {
            Console.WriteLine("Hi I am from Derived");
        }
    }
    class class8
    {
        public static void Main()
        {
            SampelA a = new SampelB();
            a.show();//example of overriding
            a.print();
        }
    }

}
