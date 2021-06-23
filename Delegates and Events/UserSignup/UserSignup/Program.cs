using System;

namespace UserSignup
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Username = "admin", Age = 21 };

            Authentication auth = new Authentication();

            // functions to be run by delegate
            Action<User> authenticationList = auth.CheckUsername;
            authenticationList += auth.CheckPassword;
            authenticationList += auth.CheckUniqueUsername;

            UserSignup userSignup = new UserSignup();

            // Event
            SendEmail sendEmail = new SendEmail();
            userSignup.UserSignedUp += sendEmail.SendConfirmationEmail;

            userSignup.AuthenticateUser(user, authenticationList);
        }
    }
}
