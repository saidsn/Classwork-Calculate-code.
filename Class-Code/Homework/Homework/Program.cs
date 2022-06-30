using System;

namespace Homework
{
    class Program
    {
       

        static void Main(string[] args)
        {
            #region Homework.Login
            string mail = "Javid.Bashirov@code.az";
            string pass = "Cavid 123";

            Account account = new Account();

            bool Islogged = account.Login(mail, pass);

            Islogin(Islogged);
            #endregion

            //Dog dog = new Dog();
            //dog.Sound();
            //dog.Eat();


            //Bird bird = new Bird();
            //bird.Sound();
            //bird.Eat();

            //Test test = new Test();
            //test.Id = 6;

            //Person person = new Person();
            //person.Speak();
            //person.Eating(DateTime.Now);

        }
        #region Homework.Login
        public static void Islogin(bool Islogin)
        {
            if (Islogin)
            {
                Console.WriteLine("Succes login");
                return;
            }
            Console.WriteLine("");


            //}
            #endregion
        }
    }   
}
