using System;

namespace UserAuthentication
{
    public class Authenticate
    {
        public event EventHandler<PersonEventArgs> Authenticated;
        public void AuthenticateUser(Person person, Action<Person> authParameters)
        {
            try
            {
                authParameters(person);

                OnAuthenticated(person);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
        }

        protected virtual void OnAuthenticated(Person person)
        {
            if (Authenticated != null)
                Authenticated(this, new PersonEventArgs() { Person = person });
        }
    }
}
