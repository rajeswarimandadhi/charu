using System;

namespace day_10
{
    class Program
    {
        //declaration
        public delegate void RectDelegate(double height, double width);

        public void area(double height, double width)
        {
            Console.WriteLine("Area is" + (width * height));
        }
        public void peimeter(double height, double width)
        {
            Console.WriteLine("perimeter is {0}", 2 * width * height);
        }
        static void Main1(string[] args)
        {
            Program c = new Program();

            RectDelegate r = new RectDelegate(c.area);
            // call 2nd method
            r = r + c.peimeter;
            r.Invoke(6.4, 6.8);
            //invoke function
            r = r - c.peimeter;
            r.Invoke(13.4, 24.6);

        }
    }
}



    

