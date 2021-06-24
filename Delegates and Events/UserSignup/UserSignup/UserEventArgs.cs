using System;
using System.Collections.Generic;
using System.Text;

namespace UserSignup
{
    public class UserEventArgs : EventArgs
    {
        public User User { get; set; }
    }
}
