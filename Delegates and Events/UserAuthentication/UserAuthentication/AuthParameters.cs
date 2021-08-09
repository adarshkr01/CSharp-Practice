using System;

namespace UserAuthentication
{
    public class AuthParameters
    {
        public void CheckUsername(Person person)
        {
            if(String.IsNullOrEmpty(person.Username))
            {
                throw new ArgumentNullException("Username cannot be null");
            }

            Console.WriteLine("Username is okay.");
        }

        public void CheckEmail(Person person)
        {
            if (String.IsNullOrEmpty(person.Email))
            {
                throw new ArgumentNullException("Email cannot be empty or null");
            }

            Console.WriteLine("Email is okay.");
        }

        public void CheckPassword(Person person)
        {
            if (String.IsNullOrEmpty(person.Password))
            {
                throw new ArgumentNullException("Password cannot be empty or null");
            }

            else if(person.Password.Length < 12)
            {
                throw new ArgumentException("Password must be 12 characters long");
            }

            Console.WriteLine("Password is okay.");
        }
    }
}
