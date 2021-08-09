using System;
using System.Collections.Generic;
using EventsPingPong.MessageTypes;

namespace EventsPingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>()
            {
                new User() { Name = "ABC", Email = "abc@gmail.com", PhoneNumber = 123 },
                new User() { Name = "DEF", Email = "def@gmail.com", PhoneNumber = 456 },
                new User() { Name = "GHI", Email = "ghi@gmail.com", PhoneNumber = 789 },
            };

            Console.WriteLine("New post published!");

            SendOutNewsletter sendOutNewsletter = new SendOutNewsletter();

            SendEmails sendEmails = new SendEmails();
            SendText sendText = new SendText();

            sendOutNewsletter.postPublished += sendEmails.Send;
            sendOutNewsletter.postPublished += sendText.Send;

            sendOutNewsletter.sendNewsletter(userList);
        }
    }
}
