using System;
using System.Collections.Generic;
using System.Text;

namespace program
{
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

    }
    class StudentImplementation
    {
        

        public bool Name { get; internal set; }

        public StudentImplementation(IList<Student> students) { }

        public StudentImplementation()
        {
        }

        public String NameofAllStudents(IList<Student> students)
        {
            String ans = "";
            foreach (Student s in students)
            {
                Console.WriteLine(s.Name);
                ans = ans + s.Name + " ";
            }
            return ans;
        }
        public int TotalScoreOfAllStudents(IList<Student> students)
        {
            int res = 0;
            foreach (Student s in students)
            {
                res = res + s.Score;
            }
            Console.WriteLine(res);
            return res;
        }
        public double AverageScore(IList<Student> students)
        {
            double res = 0;
            double i = 0;
            double avgScore = 0;
            foreach (Student s in students)
            {
                i++;
                res = res + s.Score;

            }
            if (i != 0)
                avgScore = res / i;
            Console.WriteLine(res);
            return avgScore;
        }


    }
    class Source
    {
     

        static void Main(string[] args)
        {
            StudentImplementation s = new StudentImplementation();
            IList<Student> p = new List<Student>();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
