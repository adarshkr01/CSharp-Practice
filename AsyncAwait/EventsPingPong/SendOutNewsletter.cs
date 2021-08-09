using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsPingPong
{
    public class SendOutNewsletter
    {
        public event EventHandler<UserList> postPublished;

        public void sendNewsletter(List<User> users)
        {
            onPostPublished(users);
        }

        protected virtual void onPostPublished(List<User> users)
        {
            if (postPublished != null)
                postPublished(this, new UserList() { UList = users });
        }
    }
}
