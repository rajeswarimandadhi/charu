using System;
using System.Collections.Generic;
using System.Text;

namespace day_10
{
    /// <summary>
    /// FUNc delegate
    /// Action delegate
    /// Predicate delegate
    /// </summary>
    class Class1
    {
        static int Sum(int x, int y)
        {
            return (x + y);
        }
        static void Print(int i)
        {
            Console.WriteLine(i);
        }
        static bool IsPositiveNumber(int val)
        {
            if (val > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public static void Main1()
        {
            Func<int, int, int> add = Sum;
            int result = add(18, 18);
            Console.WriteLine(result);
            Action<int> printVal = Print;
            printVal(10);
            Predicate<int> predicate = IsPositiveNumber;
            Console.WriteLine(predicate(1));
        }
    }
}



