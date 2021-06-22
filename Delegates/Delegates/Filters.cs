using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class Filters
    {
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Contrast applied");
        }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Brightness applied");
        }
    }
}
