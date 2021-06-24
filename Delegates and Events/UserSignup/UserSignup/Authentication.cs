using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UserSignup
{
    public class Authentication
    {
        public void CheckUsername(User user)
        {
            Console.WriteLine("Checking username");
            Thread.Sleep(2000);
        }

        public void CheckPassword(User user)
        {
            Console.WriteLine("Checking password");
            Thread.Sleep(2000);
        }

        public void CheckUniqueUsername(User user)
        {
            Console.WriteLine("Checking unique Username");
            Thread.Sleep(2000);
        }
    }
}
