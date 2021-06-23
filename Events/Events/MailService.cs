using System;

namespace Events
{
    public class MailService
    {
        // function signature similar to the delegate declared in VideoEncoder
        public void OnVideoEncodedRunThis(object source, EventArgs e)
        {
            Console.WriteLine("Email sent!");
        }
    }
}
