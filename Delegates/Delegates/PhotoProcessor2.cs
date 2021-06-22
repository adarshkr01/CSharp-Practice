using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    class PhotoProcessor2
    {
        public void Process(string path, Action<Photo> filterList)
        {
            Photo photo = new Photo();
            photo.Load(path);

            filterList(photo);

            photo.Save(path);
        }
    }
}
