using System;
using System.Collections.Generic;
using System.Text;

namespace day_5
{
    class MethodOverloading
    {
        public void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Sum(int a, int b, int c)
    {
        Console.WriteLine(a + b + c);
    }
    public void Sum(double a, double b)
    {
        Console.WriteLine(a + b);
    }
}
class class6
{
    public static void Main6()
    {
        MethodOverloading obj = new MethodOverloading();
        obj.Sum(1, 2);
        obj.Sum(1, 2, 3);
        obj.Sum(1.57, 2.359);
    }
}
    
    
}

