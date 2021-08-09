using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPingPong.MessageTypes
{
    public class SendText
    {
        public void Send(object source, UserList e)
        {
            foreach (User user in e.UList)
            {
                Console.WriteLine("Text message sent to " + user.PhoneNumber);
            }
        }
    }
}
