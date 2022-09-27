using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LinqQueries
{
    class Class1
    {
        public static void Main1()
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
         foreach(var item in groupResult)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("========");
            foreach(var item in groupResult)
            {
                Console.WriteLine(item.Key);
            }
           
            
        }
    }
    }

