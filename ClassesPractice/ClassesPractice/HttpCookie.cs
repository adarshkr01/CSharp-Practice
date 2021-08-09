using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesPractice
{
    class HttpCookie
    {
        private Dictionary<string, string> _dictionary = new Dictionary<string, string>();

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }

            set
            {
                _dictionary[key] = value;
            }
        }
    }
}
