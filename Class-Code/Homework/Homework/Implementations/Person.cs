using Homework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Person : Test,ISpeak, IEating
    {
        public void Eating(DateTime time)
        {
            Console.WriteLine("Person speaking -" + time);
        }

        public void Speak()
        {
            Console.WriteLine("Person speaking");
        }

    }

    









}