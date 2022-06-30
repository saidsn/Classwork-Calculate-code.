using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Account
    {

        public bool Login(string email,string password)
        {
            if (email == UserConst.Email && password == UserConst.Password)
            {
                return true;
            }
            return false;
        }
        
    }
}
