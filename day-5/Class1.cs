using System;
using System.Collections.Generic;
using System.Text;

namespace day_5
{
     abstract class Animal
    {
        public string name;
        public void getname()
        {
            Console.WriteLine("enter name of the dog");
        }
        public void setname()
        {
            name = Console.ReadLine();

        }
        abstract public void Eat();
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine(name + "is Eating !");
        }
        static void Main1(string[] args)
        {
            Dog d1 = new Dog();
            d1.getname();
            d1.setname();
            d1.Eat();
        }
    }



}


