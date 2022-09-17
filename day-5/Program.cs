using System;

namespace day_5
{
    abstract class abc
    {
        abstract public void print();
        public void show()
        {
            Console.WriteLine("asdasd");
        }
    }
    class ABC2 : abc
    {
        int a = 1;
        int b = 2;
        public override void print()
        {
            Console.WriteLine(" i am print method");
        }
        public override string ToString()



        {
            return "a = " + a + "b = " + b;

        }
    }
    class class1
    {
        public static void Main1()
        {
            //1.ToString();
            ABC2 abc = new ABC2();
            string sampl = abc.ToString();
            Console.WriteLine(sampl);
        }
    }
}
    




