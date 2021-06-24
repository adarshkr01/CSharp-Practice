using System;
using System.Collections.Generic;
using System.Text;

namespace UserSignup
{
    public class UserSignup
    {
        public event EventHandler<UserEventArgs> UserSignedUp;
        public void AuthenticateUser(User user, Action<User> authenticationList)
        {
            authenticationList(user);

            OnUserSignedUp(user);
        }

        protected virtual void OnUserSignedUp(User user)
        {
            if (UserSignedUp != null)
                UserSignedUp(this, new UserEventArgs() { User = user });
        }
    }
}
