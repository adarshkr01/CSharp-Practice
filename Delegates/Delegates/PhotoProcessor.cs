using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class PhotoProcessor
    {
        public delegate void ApplyFilters(Photo photo);
        // this delegate can have any function whose signature is "void methodName(Photo photo)"

        public void Process(string path, ApplyFilters filtersList)
        {
            Photo photo = new Photo();

            photo.Load(path);

            filtersList(photo);
            // all delegate methods are called one by one

            photo.Save(path);

        }
    }
}
