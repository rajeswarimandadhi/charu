using System;
using System.Collections.Generic;
using System.Text;

namespace day_5
{
    public class StudentAndTeacherTest
    {
        public static void Main4()
        {



            Student myStudent = new Student();
            myStudent.SetAge(19);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(25);
            myTeacher.Greet();
            myTeacher.Explain();
        }
    }
}

public class Person
{
    protected int age;
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
    public void SetAge(int n)
    {
        age = n;
    }
}
public class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }
    public void ShowAge()
    {
        Console.WriteLine("My age is {0} years old ,age");
    }
}
public class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm Explaining");

    }
}



