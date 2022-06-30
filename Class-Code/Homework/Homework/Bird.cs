using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Bird : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("bird sound");        
        }

        public override void Eat()
        {
            Console.WriteLine("Bird Eating");
        }
    }
}
