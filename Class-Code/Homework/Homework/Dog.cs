using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Dog : Animal
    {
       
        public override void Sound()
        {
            Console.WriteLine("dog sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog Eating");
        }
    }
}
