using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace LinqQueries
{
    class Student
    {
        public int Studentid { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
    class Program
    {
        public static void Main1()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("two");
            mixedList.Add("three");
            mixedList.Add(3);
            mixedList.Add(new Student() { Studentid = 1, StudentName = "vijay" });

            var stringResult = from s in mixedList.OfType<string>() select s;
            var stringResult1 = mixedList.OfType<string>();

            Console.WriteLine("=======OfType======");
            Console.WriteLine("Linq");
            foreach (var item in stringResult)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Linq to Entity");
            foreach (var item in stringResult)
            {
                Console.WriteLine(item);
            }

            IList<Student> studentlist = new List<Student>()
            {
                new Student() {Studentid=1,StudentName="vindya",StudentAge=18 },
                new Student() {Studentid=1,StudentName="vidya",StudentAge=18 },
                new Student() {Studentid=1,StudentName="viba",StudentAge=18 },
                new Student() {Studentid=1,StudentName="vinanya",StudentAge=18 },
                new Student() {Studentid=1,StudentName="vinda",StudentAge=18 }

            };

            var orderbyResult = from s in studentlist orderby s.StudentName select s;
            var orderbyResult2 = studentlist.OrderBy(x => x.StudentName);

            Console.WriteLine("======= Order By==============");
            foreach (var item in orderbyResult)
            {
                Console.WriteLine(item.StudentName);
            }

            var orderbyResultDesc = from s in studentlist orderby s.StudentName select s;
            var orderbyResultDesc2 = studentlist.OrderByDescending(x => x.StudentName);
        }
    }
}