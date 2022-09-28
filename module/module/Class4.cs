using System;
using System.Collections.Generic;
using System.Text;

namespace module
{
    class Program
    {
        static void Main5(string[] args)
        {
            int[] item = test(new[] { 10, 20, -30, -40, 50 });
            Console.Write("New array: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static int[] test(int[] numbers)
        {
            int size = numbers.Length;
            int[] shiftNums = new int[size];

            for (int i = 0; i < size; i++)
            {
                shiftNums[i] = numbers[(i + 1) % size];
            }
            return shiftNums;
        }
    }
}
