using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Calculation : ICalculation
    {
        

        public void Collection(int a,int b)
        {

            int sum = a + b; 
            Console.WriteLine(sum);
        }

        internal void Subtract()
        {
            throw new NotImplementedException();
        }

        public void Subtract(int a,int b)
        {

            int sub = a - b;
            Console.WriteLine(sub);

        }

        public void Multiply(int a, int b)
        {
            int mult = a * b;
            Console.WriteLine(mult);
        }

        public void Divide(int a, int b)
        {

            int div = a / b;
            Console.WriteLine(div);
        }

       
    }
}
