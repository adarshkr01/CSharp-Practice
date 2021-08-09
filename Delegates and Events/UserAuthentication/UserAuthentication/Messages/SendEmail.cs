using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Messages
{
    public class SendEmail
    {
        public void SendConfirmationEmail(object source, PersonEventArgs args)
        {
            Console.WriteLine("Sending confirmation email to " + args.Person.Username);
        }
    }
}
