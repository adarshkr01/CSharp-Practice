using System;
using System.Collections.Generic;
using System.Text;

namespace UserSignup
{
    public class SendEmail
    {
        public void SendConfirmationEmail(object source, UserEventArgs e)
        {
            Console.WriteLine("Confirmation Email sent to: " + e.User.Username);
        }
    }
}
