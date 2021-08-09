using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthentication
{
    public class PersonEventArgs : EventArgs
    {
        public Person Person { get; set; }
    }
}
