using System;
using UserAuthentication.Messages;

namespace UserAuthentication
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() 
                                    {   Username = "bingo", 
                                        Email = "bingo@gmail.com", 
                                        Password = "somecomplexpassword" };

            AuthParameters authParameters = new AuthParameters();
            Action<Person> auth = authParameters.CheckUsername;
            auth += authParameters.CheckEmail;
            auth += authParameters.CheckPassword;


            SendEmail sendEmail = new SendEmail();
            SendText sendText = new SendText();

            Authenticate authenticate = new Authenticate();

            authenticate.Authenticated += sendEmail.SendConfirmationEmail;
            authenticate.Authenticated += sendText.SendConfirmationText;

            authenticate.AuthenticateUser(person, auth);

            int a = Convert.ToInt32(null);
            Console.WriteLine(a);
        }
    }
}
