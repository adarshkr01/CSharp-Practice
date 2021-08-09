using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPingPong.MessageTypes
{
    public class SendEmails
    {
        public void Send(object source, UserList e)
        {
            foreach(User user in e.UList)
            {
                Console.WriteLine("Email sent to " + user.Email);
            }
        }
    }
}
