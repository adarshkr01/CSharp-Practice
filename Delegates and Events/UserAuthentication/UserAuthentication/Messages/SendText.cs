using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication.Messages
{
    public class SendText
    {
        public void SendConfirmationText(object source, PersonEventArgs args)
        {
            Console.WriteLine("Sending text message to " + args.Person.Username);
        }
    }
}
