using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinqQueries
{
    class Class2
    {
        public static bool DefaultIfEmpty { get; private set; }

        public static void Main()
        {
            

            
            IList<Student> studentlist = new List<Student>()
            {
                new Student() {Studentid=1,StudentName="vindya",StudentAge=18 },
                new Student() {Studentid=1,StudentName="vidya",StudentAge=18 },
                new Student() {Studentid=1,StudentName="viba",StudentAge=18 },
                new Student() {Studentid=1,StudentName="vinanya",StudentAge=18 },
                new Student() {Studentid=1,StudentName="vinda",StudentAge=18 }

            };

            var groupResult = from s in studentlist group s by s.StudentAge;
            var groupResult2 = studentlist.GroupBy(x => x.StudentAge);

            Console.WriteLine("=======");
            foreach (var item in groupResult)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("========");
            foreach (var item in groupResult)
            {
                Console.WriteLine(item.Key);
            }

            //Contains
            var sample = studentlist.Select(x => x.StudentName.Contains("vikash"));
            foreach(var item in sample)
            {
                Console.WriteLine(item);
            }

            //Aggregate
            Console.WriteLine("==============");
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(10);

            Console.WriteLine("========Aggregate=========");
            IList<string> strList = new List<string>() { "one", "two", "three", "four" };
            var commasepatedstring = strList.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine(commasepatedstring );


            Console.WriteLine("======Average======");
            //Average
            var average = intList.Average();
            Console.WriteLine(average);


            Console.WriteLine("======Count=====");
            //Count
            var count = intList.Count();
            Console.WriteLine(count);

            //Max
            Console.WriteLine("=====Max=====");
            var max = intList.Max();
            Console.WriteLine(max);

            //Sum
            Console.WriteLine("=====Sum=====");
            var sum = intList.Sum();
            Console.WriteLine(sum);

            //DefaultIfEmpty
            Console.WriteLine("=======DefaultIfEmpty========");
            var DefaultIfEmplty = intList.DefaultIfEmpty();
            Console.WriteLine(DefaultIfEmpty);
        }
    }
}
   
